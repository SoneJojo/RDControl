using RDControl.App.Base;
using RDControl.App.ViewModel;
using RDControl.Domain.Base;
using RDControl.Domain.Entities;
using RDControl.Service.Validators;
using static RDControl.Domain.Entities.Report;

namespace RDControl.App.Register
{
    public partial class ReportForm : BaseRegisterForm
    {
        private IBaseService<Report> _reportService;
        private List<ReportViewModel>? reports;

        private IBaseService<Technician> _technicianService;
        private IBaseService<Equipment> _equipmentService;
        private IBaseService<User> _userService;
        public ReportForm(IBaseService<Report> reportService, IBaseService<Technician> technicianService, IBaseService<Equipment> equipmentService, IBaseService<User> userService)
        {
            _reportService = reportService;
            _technicianService = technicianService;
            _equipmentService = equipmentService;
            _userService = userService;
            InitializeComponent();
            LoadCombo();
        }
        private void LoadCombo()
        {
            cboSituation.DataSource = Enum.GetValues(typeof(SituationType));
            cboPayment.DataSource = Enum.GetValues(typeof(PaymentType));
            cboEquipment.ValueMember = "Id";
            cboEquipment.DisplayMember = "Model";
            cboEquipment.DataSource = _equipmentService.Get<EquipmentViewModel>().ToList();
            cboTechnician.ValueMember = "Id";
            cboTechnician.DisplayMember = "Name";
            cboTechnician.DataSource = _technicianService.Get<TechnicianViewModel>().ToList();
            cboUser.ValueMember = "Id";
            cboUser.DisplayMember = "Name";
            cboUser.DataSource = _userService.Get<UserViewModel>().ToList();
        }
        private void FormToObject(Report report)
        {
            report.Date = dtpDate.Value;
            report.Ticket = txtTicket.Text;
            report.Hours = decimal.Parse(txtHours.Text);
            report.Hours_price = decimal.Parse(txtHourlyRate.Text);
            report.Description = txtDescription.Text;
            report.Observation = txtObservation.Text;
            report.Payment = (PaymentType)cboPayment.SelectedItem;
            report.Situation = (SituationType)cboSituation.SelectedItem;
            if (int.TryParse(cboEquipment.SelectedValue.ToString(), out int equipmentId)){
                var equip = _equipmentService.GetById<Equipment>(equipmentId);
                report.Equip = equip;
            }
            if (int.TryParse(cboTechnician.SelectedValue.ToString(), out int technicianId)){
                var tech = _technicianService.GetById<Technician>(technicianId);
                report._Technician = tech;
            }
            if (int.TryParse(cboUser.SelectedValue.ToString(), out int userId)){
                var user = _userService.GetById<User>(userId);
                report._User = user;
            }
        }
        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var report = _reportService.GetById<Report>(id);
                    FormToObject(report);
                    report = _reportService.Update<Report, Report, ReportValidator>(report);
                }
                else
                {
                    var report = new Report();
                    FormToObject(report);
                    _reportService.Add<Report, Report, ReportValidator>(report);
                }
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Duda RD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void Delete(int id)
        {
            try
            {
                _reportService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Duda RD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void PopulateGrid()
        {
            reports = _reportService.Get<ReportViewModel>().ToList();
            dataGridViewList.DataSource = reports ;
            dataGridViewList.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Equip"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Situation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["_Technician"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["_User"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Ticket"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Observation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Hours"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Hours_price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Payment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            dtpDate.Value = DateTime.Parse(record?.Cells["Date"].Value.ToString());
            cboEquipment.SelectedValue = record?.Cells["Equip"].Value;
            cboSituation.SelectedItem = record?.Cells["Situation"].Value;
            cboTechnician.SelectedValue = record?.Cells["_Technician"].Value;
            cboUser.SelectedItem = record?.Cells["_User"].Value;
            txtTicket.Text = record?.Cells["Ticket"].Value.ToString();
            txtDescription.Text = record?.Cells["Description"].Value.ToString();
            txtObservation.Text = record?.Cells["Observation"].Value.ToString();
            txtHours.Text = record?.Cells["Hours"].Value.ToString();
            txtHourlyRate.Text = record?.Cells["Hours_price"].Value.ToString();
            cboPayment.SelectedItem = record?.Cells["Payment"].Value;
        }
    }
}
