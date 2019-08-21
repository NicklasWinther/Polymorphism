using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Entities
{
    public class SalesRepresentative : BaseSalariedEmployee
    {
        protected decimal weeklySales;
        protected double commisionRate;

        public override decimal Earnings()
        {
            throw new NotImplementedException();
        }
    }
}
