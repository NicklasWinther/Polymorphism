using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Entities
{
    class Invoice : IPayable
    {
        protected List<Product> products;

        public decimal GetPaymentAmount()
        {
            throw new NotImplementedException();
        }
    }
}
