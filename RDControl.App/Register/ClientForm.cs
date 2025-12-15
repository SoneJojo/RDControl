using RDControl.App.Base;
using RDControl.App.ViewModel;
using RDControl.Domain.Base;
using RDControl.Domain.Entities;
using RDControl.Service.Validators;

namespace RDControl.App.Register
{
    public partial class ClientForm : BaseRegisterForm
    {
        private IBaseService<Client> _clientService;
        private List<ClientViewModel>? clients;
        public ClientForm(IBaseService<Client> clientService)
        {
            _clientService = clientService;
            InitializeComponent();
        }
        private void FormToObject(Client client)
        {
            client.Name = txtName.Text;
            client.CNPJ = txtCNPJ.Text;
        }
        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var client = _clientService.GetById<Client>(id);
                    FormToObject(client);
                    client = _clientService.Update<Client, Client, ClientValidator>(client);
                }
                else
                {
                    var client = new Client();
                    FormToObject(client);
                    _clientService.Add<Client, Client, ClientValidator>(client);
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
                _clientService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Duda RD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void PopulateGrid()
        {
            clients = _clientService.Get<ClientViewModel>().ToList();
            dataGridViewList.DataSource = clients;
            dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["CNPJ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtName.Text = record?.Cells["Name"].Value.ToString();
            txtCNPJ.Text = record?.Cells["CNPJ"].Value.ToString();
        }
    }
}
