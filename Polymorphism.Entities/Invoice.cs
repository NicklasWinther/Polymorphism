using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Entities
{
    class Invoice : Entity, IPayable
    {
        protected List<Product> products;

        public List<Product> Products { get; set; }

        public Invoice(List<Product> products)
            :this(default, products)
        {
            Products = products;
        }

        public Invoice(int id, List<Product> products)
            :base(id)
        {
            Products = products;
        }

        public decimal GetPaymentAmount()
        {
            decimal payment = 0;
            foreach (Product product in Products)
            {
                payment += product.Price * product.Quantity;
            }
            return payment;
        }
    }
}
