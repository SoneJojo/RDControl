using RDControl.App.Base;
using RDControl.App.ViewModel;
using RDControl.Domain.Base;
using RDControl.Domain.Entities;
using RDControl.Service.Validators;
using static RDControl.Domain.Entities.Technician;

namespace RDControl.App.Register
{
    public partial class TechnicianForm : BaseRegisterForm
    {
        private IBaseService<Technician> _technicianService;
        private List<TechnicianViewModel>? technicians;
        public TechnicianForm(IBaseService<Technician> technicianService)
        {
            _technicianService = technicianService;
            InitializeComponent();
            LoadCombo();
        }
        private void FormToObject(Technician technician)
        {
            technician.Name = txtName.Text;
            technician.CPF = txtCPF.Text;
            technician.TechType = (TechnicianType)cboTechType.SelectedItem;
        }

        private void LoadCombo()
        {
            cboTechType.DataSource = Enum.GetValues(typeof(TechnicianType));
        }
        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var technician = _technicianService.GetById<Technician>(id);
                    FormToObject(technician);
                    technician = _technicianService.Update<Technician, Technician, TechnicianValidator>(technician);
                }
                else
                {
                    var technician = new Technician();
                    FormToObject(technician);
                    _technicianService.Add<Technician, Technician, TechnicianValidator>(technician);
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
                _technicianService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Duda RD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void PopulateGrid()
        {
            technicians = _technicianService.Get<TechnicianViewModel>().ToList();
            dataGridViewList.DataSource = technicians;
            dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["CPF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["TechType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtName.Text = record?.Cells["Name"].Value.ToString();
            txtCPF.Text = record?.Cells["CPF"].Value.ToString();
            cboTechType.SelectedItem = record?.Cells["TechType"].Value;
        }
    }
}