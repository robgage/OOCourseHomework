using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LifeInsuranceCalculator
{
    public class ApplicantDetails
    {
        public int Age { get; set; }
        public bool? isMale { get; set; }
        public string PostCode { get; set; }
        public bool? IsSmoker { get; set; }
        public int WeeklyExcercise { get; set; }
        public bool? HasChildren { get; set; }    
        public CountryOfResidence.Country Country { get; set; }    

        public int CalculateAgeFromDateOfBirth(string input)
        {
            DateOfBirth Date = new DateOfBirth();
            Age =  Date.CalculateAgeFromDOB(input);
            return Age;
        }

        public bool? SetGender(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new NullReferenceException("Please enter a valid key");
            }

            if (input == "1")
            {
                isMale = true;
            }
            else if (input == "2")
            {
                isMale = false;
            }
            return isMale;
        }

        public bool? SetSmoker(string input)
        {
            if (input.ToUpper() == "Y")
            {
                IsSmoker = true;
            }
            else if (input.ToUpper() == "N")
            {
                IsSmoker = false;
            }
            else
            {
                ItsAllBroken();
            }
            return IsSmoker;
        }

        public bool? SetChildren(string input)
        {
            if (input.ToUpper() == "Y")
            {
                HasChildren = true;
            }
            else if (input.ToUpper() == "N")
            {
                HasChildren = false;
            }
            else
            {
                ItsAllBroken();
            }
            return HasChildren;
        }

        public void ItsAllBroken()
        {
            Console.WriteLine("An invalid selection has been made");
            Console.WriteLine("Please press any key to start again");
            Console.ReadLine();
            Environment.Exit(0);
        }

    }
}
