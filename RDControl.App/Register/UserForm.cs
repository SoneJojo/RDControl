using RDControl.App.Base;
using RDControl.App.ViewModel;
using RDControl.Domain.Base;
using RDControl.Domain.Entities;
using RDControl.Service.Validators;

namespace RDControl.App.Register
{
    public partial class UserForm : BaseRegisterForm
    {
        private IBaseService<User> _userService;
        private List<UserViewModel>? users;
        public UserForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }
        private void FormToObject(User user)
        {
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Login = txtLogin.Text;
            user.Password = txtPassword.Text;
            user.RegisterDate = DateTime.Now;
        }
        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var user = _userService.GetById<User>(id);
                    FormToObject(user);
                    user = _userService.Update<User, User, UserValidator>(user);
                }
                else
                {
                    var user = new User();
                    FormToObject(user);
                    _userService.Add<User, User, UserValidator>(user);
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
                _userService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Duda RD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void PopulateGrid()
        {
            users = _userService.Get<UserViewModel>().ToList();
            dataGridViewList.DataSource = users;
            dataGridViewList.Columns["Password"]!.Visible = false;
            dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Login"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtName.Text = record?.Cells["Name"].Value.ToString();
            txtLogin.Text = record?.Cells["Login"].Value.ToString();
            txtEmail.Text = record?.Cells["Email"].Value.ToString();
            txtPassword.Text = record?.Cells["Password"].Value.ToString();
        }
        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkPassword.Checked ? '\0' : '*';
        }
    }
}
