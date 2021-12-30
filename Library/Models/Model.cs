using System;

namespace Library.Models
{
    public abstract class Model
    {
        public Guid Id { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; set; }

        public Model()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }
    }
}
