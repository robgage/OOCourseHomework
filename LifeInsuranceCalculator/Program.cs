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
            Console.WriteLine("Welcome to Life Insurance Quote Calculator");

            ApplicantDetails quote = new DataCollection().CollectQuoteData();
                        
            Console.WriteLine("Thank you, calculating your quote");

            CalculateQuote CQ = new CalculateQuote();
            decimal premium = CQ.CalculateFinalQuote(quote);

            if (premium < CQ.MinimumPremium)
            {
                premium = CQ.MinimumPremium;
            }

            Console.WriteLine("Your Life Insurance Quote is {0}", premium.ToString("C0"));
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
            
        }

        
    }
}
