namespace Library.Models
{
    public class User : Model
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public User(string name, string email, string password) : base()
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public bool CheckPassword(string password)
        {
            return Password == password;
        }

    }
}
