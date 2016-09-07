using System;
using NUnit.Framework;
using LifeInsuranceCalculator;

namespace LifeInsuranceCalculator
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void TestAgeCalculated_WhenBirthdayAlreadyPassedThisYear()
        {
            DateTime test = new DateTime(DateTime.Now.AddYears(-37).Year,1,1);
            DateOfBirth DOB = new DateOfBirth();
            Assert.AreEqual(DOB.CalculateAgeFromDOB(test.ToString("dd/MM/yyyy")), 37);            
        }

        [Test]
        public void TestAgeCalculated_WhenBirthdayIsLaterInYear()
        {
            DateTime test = new DateTime(DateTime.Now.AddYears(-37).Year, 12, 31);
            DateOfBirth DOB = new DateOfBirth();
            Assert.AreEqual(DOB.CalculateAgeFromDOB(test.ToString("dd/MM/yyyy")), 36);            
        }

        [Test]
        public void WhenMaleSelected_IsMaleReturnsTrue()
        {
            ApplicantDetails foo = new ApplicantDetails();
            Assert.AreEqual(foo.SetGender("1"), true);
        }

        [Test]
        public void WhenFemaleIsSelected_IsMaleReturnsFalse()
        {
            ApplicantDetails foo = new ApplicantDetails();
            Assert.AreEqual(foo.SetGender("2"), false);
        }


        [Test]
        public void WhenYEnteredForSmoker_IsSmokerReturnsTrue()
        {
            ApplicantDetails foo = new ApplicantDetails();
            Assert.AreEqual(foo.SetSmoker("Y"), true);
        }

        [Test]
        public void WhenNEnteredForSmoker_IsSmokerReturnsFalse()
        {
            ApplicantDetails foo = new ApplicantDetails();
            Assert.AreEqual(foo.SetSmoker("N"), false);
        }


        [Test]
        public void WhenYSelected_HasChildrenIsTrue()
        {
            ApplicantDetails foo = new ApplicantDetails();
            Assert.AreEqual(foo.SetChildren("Y"), true);
        }

        [Test]
        public void WhenNSelected_HasChildrenIsFalse()
        {
            ApplicantDetails foo = new ApplicantDetails();
            Assert.AreEqual(foo.SetChildren("N"), false);
        }

       
        // Consider a rates test class to cover all of these rather than just a couple??
        [Test]  
        public void BaseRateFor10YearOldBoy_ShouldBe150()
        {
            BasePrice b = new BasePrice();
            ApplicantDetails foo = new ApplicantDetails { Age = 10, isMale=true };
            Assert.AreEqual(b.ReturnBasePrice(foo),150);

        }

        [Test]
        public void BaseRateFor70YearOldFemale_ShouldBe485()
        {
            BasePrice b = new BasePrice();
            ApplicantDetails foo = new ApplicantDetails { Age = 70, isMale = false };
            Assert.AreEqual(b.ReturnBasePrice(foo), 485);
        }

        [Test]
        public void NoChildren_ShouldNotLoadPremiun()
        {
            ChildLoading child = new ChildLoading();
            Assert.AreEqual(child.ApplyChildLoading(100, false),100);
        }

        [Test]
        public void WithChildren_ShouldIncreasePremiumBy50Percent()
        {
            ChildLoading child = new ChildLoading();
            Assert.AreEqual(child.ApplyChildLoading(100, true), 150);
        }

        [Test]
        public void IfTheApplicantIsANonSmoker_ThenNoSmokerLoadingIsApplied()
        {
            SmokerLoading Smoke = new SmokerLoading();
            Assert.AreEqual(Smoke.ApplySmokerLoading(100, false), 100);
        }

        [Test]
        public void IfTheApplicantIsASmoker_ThenLoadBy300Percent()
        {
            SmokerLoading Smoke = new SmokerLoading();
            Assert.AreEqual(Smoke.ApplySmokerLoading(100, true), 300);
        }

        [Test]
        public void PremiumChange_BasedOnExcerciseLevels()
        {
            HealthyLifeStyleBonus hl = new HealthyLifeStyleBonus();
            Assert.AreEqual(hl.ApplyLifeStyleBonus(100, 0), 120);
            Assert.AreEqual(hl.ApplyLifeStyleBonus(100, 1), 100);
            Assert.AreEqual(hl.ApplyLifeStyleBonus(100, 3), 70);
            Assert.AreEqual(hl.ApplyLifeStyleBonus(100, 6), 50);
            Assert.AreEqual(hl.ApplyLifeStyleBonus(100, 10), 150);
        }

        [Test]
        public void RegionalHealthIndexEngland_AppliesNoDiscountOrLoad()
        {
            CountryOfResidence bar = new CountryOfResidence();
            ApplicantDetails foo = new ApplicantDetails();

            foo.Country = CountryOfResidence.Country.England;
            Assert.AreEqual(bar.ReturnRHIDifference(foo.Country), 0);
            
        }

        [Test]
        public void CorrectFinalPremiumCalculated()
        {
            ApplicantDetails app = new ApplicantDetails();
            app.Age = 36;
            app.isMale = true;
            app.Country = CountryOfResidence.Country.England;
            app.HasChildren = true;
            app.IsSmoker = false;
            app.WeeklyExcercise = 2;

            CalculateQuote CQ = new CalculateQuote();

            Assert.AreEqual(CQ.CalculateFinalQuote(app), 375);
        }
    }
}