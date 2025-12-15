using RDControl.App.Base;
using RDControl.App.ViewModel;
using RDControl.Domain.Base;
using RDControl.Domain.Entities;
using RDControl.Service.Validators;

namespace RDControl.App.Register
{
    public partial class EquipmentForm : BaseRegisterForm
    {
        private IBaseService<Equipment> _equipmentService;
        private List<EquipmentViewModel>? equipments;
        private IBaseService<Place> _placeService;

        public EquipmentForm(IBaseService<Equipment> equipmentService, IBaseService<Place> placeService)
        {
            _placeService = placeService;
            _equipmentService = equipmentService;
            InitializeComponent();
            LoadCombo();
        }
        private void FormToObject(Equipment equipment)
        {
            equipment.Model = txtModel.Text;
            equipment.Serial = txtSerial.Text;
            if(int.TryParse(cboPlace.SelectedValue.ToString(), out int placeId))
            {
                var place = _placeService.GetById<Place>(placeId);
                equipment._Place = place;
            } 
        }
        private void LoadCombo()
        {
            cboPlace.ValueMember = "Id";
            cboPlace.DisplayMember = "Pname";
            cboPlace.DataSource = _placeService.Get<PlaceViewModel>().ToList();
        }
        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtID.Text, out int id);
                    var equipment = _equipmentService.GetById<Equipment>(id);
                    FormToObject(equipment);
                    equipment = _equipmentService.Update<Equipment, Equipment, EquipmentValidator>(equipment);
                }
                else
                {
                    var equipment = new Equipment();
                    FormToObject(equipment);
                    _equipmentService.Add<Equipment, Equipment, EquipmentValidator>(equipment);
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
                _equipmentService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Duda RD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void PopulateGrid()
        {
            equipments = _equipmentService.Get<EquipmentViewModel>().ToList();
            dataGridViewList.DataSource = equipments;
            dataGridViewList.Columns["Serial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Model"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["_Place"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void GridToForm(DataGridViewRow? record)
        {
            txtID.Text = record?.Cells["Id"].Value.ToString();
            txtSerial.Text = record?.Cells["Serial"].Value.ToString();
            txtModel.Text = record?.Cells["Model"].Value.ToString();
            cboPlace.SelectedItem = record?.Cells["_Place"].Value;
        }
    }
}
