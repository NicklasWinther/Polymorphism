using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Entities
{
    public abstract class Employee : IPayable
    {
        protected string name;

        public abstract decimal Earnings();

        public decimal GetPaymentAmount()
        {
            throw new NotImplementedException();
        }
    }
}
