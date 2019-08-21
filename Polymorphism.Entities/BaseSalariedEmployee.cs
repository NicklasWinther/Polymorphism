using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Entities
{
    public class BaseSalariedEmployee : Employee
    {
        protected decimal salary;

        public override decimal Earnings()
        {
            throw new NotImplementedException();
        }
    }
}
