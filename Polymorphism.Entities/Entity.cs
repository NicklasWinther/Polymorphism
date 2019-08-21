using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Entities
{
    public abstract class Entity : IPersistable
    {
        protected int id;

        public int Id { get; }
    }
}
