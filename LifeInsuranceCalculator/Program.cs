using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsuranceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicantDetails quote = new ApplicantDetails();
            Console.WriteLine("Welcome to Life Insurance Quote Calculator");
            Console.WriteLine("Please enter your date of birth in dd/mm/yyyy format. For example today is {0}/{1}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            quote.Age = quote.CalculateAgeFromDateOfBirth(Console.ReadLine());
            
        }
    }
}
