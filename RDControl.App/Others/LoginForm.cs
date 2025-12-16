using RDControl.App.Base;
using RDControl.Domain.Base;
using RDControl.Domain.Entities;
using RDControl.Service.Validators;

namespace RDControl.App.Others
{
    public partial class LoginForm : BaseForm
    {
        private readonly IBaseService<User> _userService;
        public LoginForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = ReceiveUser(txtLogin.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Login e/ou senha inválidos!", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                user = _userService.Update<User, User, UserValidator>(user);
                MainForm.user = user;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkPassword.Checked ? '\0' : '*';
        }
        private User? ReceiveUser(string login, string password)
        {
            CheckCredentials();
            var user = _userService.Get<User>().Where(u => u.Login == login).FirstOrDefault();
            if (user == null)
            {
                return null;
            }
            else
            {
                return user.Password != password ? null : user;
            }
        }

        private void CheckCredentials()
        {
            var users = _userService.Get<User>().ToList();
            if (!users.Any())
            {
                var user = new User() { Login = "admin", Password = "!Admin00", Name = "Administrator", Email = "admin@gmail.com", RegisterDate = DateTime.Now };
                _userService.Add<User, User, UserValidator>(user);
            }
        }
    }
}
