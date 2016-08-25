using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsuranceCalculator
{
    public class SmokerLoading
    {
        private static int SmokeLoading = 3;

        public int ApplySmokerLoading(int premium, bool? isSmoker)
        {
            if (isSmoker == true)
            {
                return premium * SmokeLoading;
            }
            else return premium;
        }
    }
}
