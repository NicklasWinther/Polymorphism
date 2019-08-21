using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Entities
{
    public abstract class Entity : IPersistable
    {
        protected int id;

        public int Id { get; }

        public Entity(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("Id skal være over 0");
            }
            this.id = id;
        }
    }
}
