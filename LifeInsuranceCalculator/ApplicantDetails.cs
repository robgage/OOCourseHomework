using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LifeInsuranceCalculator
{
    class ApplicantDetails
    {
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PostCode { get; set; }
        public bool IsSmoker { get; set; }
        public int WeeklyExcercise { get; set; }
        public bool HasChildren { get; set; }

        public int CalculateAgeFromDateOfBirth(string input)
        {
            DateOfBirth Date = new DateOfBirth();
            Age =  Date.CalculateAgeFromDOB(input);
            return Age;
        }

    }
}
