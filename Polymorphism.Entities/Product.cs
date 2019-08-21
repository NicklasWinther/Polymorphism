using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Entities
{
    public class Product : Entity
    {
        protected string name;
        protected decimal price;
        protected int quantity;

        public Product(string name, decimal price, int quantity)
            :this(default, name, price, quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Product(int id, string name, decimal price, int quantity)
            :base(id)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
