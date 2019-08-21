using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Entities
{
    public class BaseSalariedEmployee : Employee
    {
        protected decimal salary;
        public decimal Salary { get; set; }

        public BaseSalariedEmployee(int id, string name, decimal salary)
            : base(id, name)
        {
            Salary = salary;
        }
        public BaseSalariedEmployee(string name, decimal salary)
            : this(default, name, salary)
        {
            Salary = salary;
        }


        public override decimal Earnings()
        {
            throw new NotImplementedException();
        }
    }
}
