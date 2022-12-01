using System;

namespace Todo.Domain.Entities
{
    public abstract class Entity
    {
        // Guid é um identificador único
        public Guid Id { get; private set; }
        
    }
}