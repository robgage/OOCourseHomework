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
            DateTime DOB = new DateTime();
            try
            {
                DOB = Convert.ToDateTime(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not a valid date", input);
                ApplicantDetails foo = new ApplicantDetails();
                foo.ItsAllBroken();
            }
            
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
