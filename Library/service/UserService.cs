using Library.Models;
using Library.Repo;
using System;

namespace Library.Service
{
    public class UserService
    {
        private UserRepository _repository;

        public UserService(UserRepository repository)
        {
            _repository = repository;
        }

        public void CreateUser(User user)
        {
            var userExists = _repository.FindByEmail(user.Email) != null;

            if (userExists) throw new Exception("");

            _repository.Insert(user);
        }
        public bool Login(string email, string senha)
        {
            return _repository.FindByEmail(email)?.CheckPassword(senha) == true;
        }
    }
}
