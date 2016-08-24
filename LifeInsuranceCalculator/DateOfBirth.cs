using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsuranceCalculator
{
    public class DateOfBirth
    {
        public int Age { get; set; }

        public int CalculateAgeFromDOB(string input)
        {
            DateTime DOB = Convert.ToDateTime(input);
            DateTime today = DateTime.Today;
            Age = today.Year - DOB.Year;

            if (DOB > today.AddYears(-Age))
            {
                Age--;
            }
            
            return Age;
        }

    }
}
