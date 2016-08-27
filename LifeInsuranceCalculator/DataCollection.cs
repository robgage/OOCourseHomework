using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsuranceCalculator
{
    class DataCollection
    {
        public ApplicantDetails CollectQuoteData()
        {
            ApplicantDetails quote = new ApplicantDetails();
            Console.WriteLine("Please enter your date of birth in dd/mm/yyyy format. For example today is {0}/{1}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            quote.Age = quote.CalculateAgeFromDateOfBirth(Console.ReadLine());

            Console.WriteLine("Please Select Your Gender {0} 1. Male {0} 2. Female", Environment.NewLine);
            quote.isMale = quote.SetGender(Console.ReadLine());

            CountryOfResidence country = new CountryOfResidence();
            quote.Country = country.SelectCountry();

            Console.WriteLine("Please Enter your post code");
            quote.PostCode = Console.ReadLine();

            Console.WriteLine("Are you a smoker?, please enter Y for Yes, N for No");
            quote.IsSmoker = quote.SetSmoker(Console.ReadLine());

            Console.WriteLine("Please tell us how many hours of excercise you do in a week");
            quote.WeeklyExcercise = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Do you have any children?, please enter Y for Yes, N for No");
            quote.HasChildren = quote.SetChildren(Console.ReadLine());

            return quote;
        }
    }
}
