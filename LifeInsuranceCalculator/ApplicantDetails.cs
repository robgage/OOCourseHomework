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

        public int CalculateAgeFromDateOfBirth(string input)
        {
            DateOfBirth Date = new DateOfBirth();
            Age =  Date.CalculateAgeFromDOB(input);
            return Age;
        }

        public bool? SetGender(string input)
        {
            if (input == "1")
            {
                isMale = true;
            }
            else if (input == "2")
            {
                isMale = false;
            }
            else
            {
                isMale = null;
                Console.WriteLine("please start again");
            }
            return isMale;
        }

        public bool? SetSmoker(string input)
        {
            if (input == "Y")
            {
                IsSmoker = true;
            }
            else if (input == "N")
            {
                IsSmoker = false;
            }
            else
            {
                Console.WriteLine("please start again");
                IsSmoker = null;
            }
            return IsSmoker;
        }

        public bool? SetChildren(string input)
        {
            if (input == "Y")
            {
                HasChildren = true;
            }
            else if (input == "N")
            {
                HasChildren = false;
            }
            else
            {
                HasChildren = null;
                Console.WriteLine("please try again");
            }
            return HasChildren;
        }

    }
}
