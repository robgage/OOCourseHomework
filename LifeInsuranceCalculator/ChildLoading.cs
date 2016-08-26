using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsuranceCalculator
{
    public class ChildLoading
    {
        public decimal LoadAmount = 0.5M;
        public decimal ApplyChildLoading(decimal Premium, bool? hasChildren)
        {
            if (hasChildren == true)
            {
                var Load = Premium * LoadAmount;
                return Premium + Load;
            }
            else
            {
                return Premium;
            }
        }
    }
}
