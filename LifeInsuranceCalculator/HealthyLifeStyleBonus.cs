using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsuranceCalculator
{
    public class HealthyLifeStyleBonus
    {
        private double Load { get; set; }
        public double ApplyLifeStyleBonus(int premium, int HoursExcercise)
        {
            if (HoursExcercise == 0)
            {
                Load = 1.2;
            }
            else if (HoursExcercise == 1 || HoursExcercise == 2)
            {
                return premium;
            }
            else if (HoursExcercise >= 3 && HoursExcercise <=5)
            {
                Load = 0.7;
            }
            else if (HoursExcercise >= 6 && HoursExcercise <= 8)
            {
                Load = 0.5;
            }
            else if (HoursExcercise >= 9)
            {
                Load = 1.5;
            }

            var result = premium * Load;
            return result;
        }
    }
}
