using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsuranceCalculator
{
    public class ChildLoading
    {
        public double LoadAmount = 0.5;
        public double ApplyChildLoading(double Premium, bool? hasChildren)
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
