using Library.Models;
using System.Collections.Generic;

namespace Library.Repo
{
    public class UserRepository
    {
        private List<User> repository;

        public UserRepository()
        {
            repository = new List<User>();
        }

        public void Insert(User user) => repository.Add(user);

        public User? FindByEmail(string email)
        {
            return repository.Find(u => u.Email == email);

        }
    }
}
