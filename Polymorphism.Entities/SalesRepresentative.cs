using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Entities
{
    public class SalesRepresentative : BaseSalariedEmployee
    {
        protected decimal weeklySales;
        protected double commisionRate;

        public decimal WeeklySales { get; set; }
        public double CommisionRate { get; set; }

        public SalesRepresentative(int id, string name,  decimal salary, decimal weeklySales, double commisionRate) 
            : base(id, name, salary)
        {
            WeeklySales = weeklySales;
            CommisionRate = commisionRate;
        }

        public override decimal Earnings()
        {
            return base.Earnings() + WeeklySales * (decimal)CommisionRate;
        }
    }
}
