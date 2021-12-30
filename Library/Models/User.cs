using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class User : Model
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Name { get; private set; }
        
        [EmailAddress]
        public string Email { get; private set; }
        
        [Required]
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

        public static class Validation<T> where T : Model
        {
            public static IEnumerable<ValidationResult> Execute(T obj)
            {
                var errors = new List<ValidationResult>();
                var context = new ValidationContext(obj, null, null);
                Validator.TryValidateObject(obj, context, errors, true);
                return errors;
            }
        }
    }
}
