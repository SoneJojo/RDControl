using RDControl.Domain.Base;

namespace RDControl.Domain.Entities
{
    public class User : BaseEntity<int>
    {
        public User()
        {
        }
        public User(int id, string name, string email, string login, string password, DateTime registerDate)
        {
            Name = name;
            Email = email;
            Login = login;
            Password = password;
            RegisterDate = registerDate;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
