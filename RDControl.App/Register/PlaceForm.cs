using RDControl.App.Base;
using RDControl.App.ViewModel;
using RDControl.Domain.Base;
using RDControl.Domain.Entities;
using RDControl.Service.Validators;

namespace RDControl.App.Register
{
    public partial class PlaceForm : BaseRegisterForm
    {
        #region Constructor and Variables
        private IBaseService<Place> _placeService;
        private List<PlaceViewModel>? places;
        private IBaseService<Client> _clientService;
        public PlaceForm(IBaseService<Place> placeService, IBaseService<Client> clientService)
        {
            _placeService = placeService;
            _clientService = clientService;
            InitializeComponent();
            LoadCombo();
        }
        #endregion

        #region Methods
        private void LoadCombo()
        {
            cboClient.ValueMember = "Id";
            cboClient.DisplayMember = "Name";
            cboClient.DataSource = _clientService.Get<ClientViewModel>().ToList();
        }
        private void FormToObject(Place place)
        {
            place.Pname = txtPlace.Text;
            place.Address = txtAddress.Text;
            if (int.TryParse(cboClient.SelectedValue.ToString(), out int clientId))
            {
                var client = _clientService.GetById<Client>(clientId);
                place._Client = client;
            }
        }
        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var place = _placeService.GetById<Place>(id);
                    FormToObject(place);
                    place = _placeService.Update<Place, Place, PlaceValidator>(place);
                }
                else
                {
                    var place = new Place();
                    FormToObject(place);
                    _placeService.Add<Place, Place, PlaceValidator>(place);
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
                _placeService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Duda RD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void PopulateGrid()
        {
            places = _placeService.Get<PlaceViewModel>().ToList();
            dataGridViewList.DataSource = places;
            dataGridViewList.Columns["Pname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["_Client"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtPlace.Text = record?.Cells["Pname"].Value.ToString();
            txtAddress.Text = record?.Cells["Address"].Value.ToString();
            cboClient.SelectedItem = record?.Cells["_Client"].Value;
        }
        #endregion
    }
}
