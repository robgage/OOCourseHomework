using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsuranceCalculator
{
    public class CalculateQuote
    {
        public decimal MinimumPremium = 50;
        public decimal CalculateFinalQuote(ApplicantDetails quote)
        {
            decimal BasePremium = new BasePrice().ReturnBasePrice(quote);

            decimal AfterRHI = BasePremium + new CountryOfResidence().ReturnRHIDifference(quote.Country);

            ChildLoading child = new ChildLoading();
            decimal PremiumAfterChildLoad = child.ApplyChildLoading(AfterRHI, quote.HasChildren);

            SmokerLoading smoke = new SmokerLoading();
            decimal PremiumAfterSmoking = smoke.ApplySmokerLoading(PremiumAfterChildLoad, quote.IsSmoker);

            HealthyLifeStyleBonus HLB = new HealthyLifeStyleBonus();
            decimal PremiumAfterLifeStyleAdjustment = HLB.ApplyLifeStyleBonus(PremiumAfterSmoking, quote.WeeklyExcercise);

            return PremiumAfterLifeStyleAdjustment;
        }

        public void CalculationError(string errorcode)
        {
            Console.WriteLine("Unable to calculate quote due to missing {0}",errorcode);
            Console.WriteLine("Please press any key to start again");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
