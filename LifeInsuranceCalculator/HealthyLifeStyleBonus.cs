using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsuranceCalculator
{
    public class HealthyLifeStyleBonus
    {
        private decimal Load { get; set; }
        public decimal ApplyLifeStyleBonus(decimal premium, int HoursExcercise)
        {
            if (HoursExcercise == 0)
            {
                Load = 1.2M;
            }
            else if (HoursExcercise == 1 || HoursExcercise == 2)
            {
                return premium;
            }
            else if (HoursExcercise >= 3 && HoursExcercise <=5)
            {
                Load = 0.7M;
            }
            else if (HoursExcercise >= 6 && HoursExcercise <= 8)
            {
                Load = 0.5M;
            }
            else if (HoursExcercise >= 9)
            {
                Load = 1.5M;
            }

            var result = premium * Load;
            return result;
        }
    }
}
