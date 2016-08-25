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
            DateOfBirth DOB = new DateOfBirth();
            Assert.AreEqual(DOB.CalculateAgeFromDOB("07/01/1979"), 37);
            // Make this cope with a target age rather than a fixed date which will require test changed on 7/12/2016!!1
        }

        [Test]
        public void TestAgeCalculated_WhenBirthdayIsLaterInYear()
        {
            DateOfBirth DOB = new DateOfBirth();
            Assert.AreEqual(DOB.CalculateAgeFromDOB("31/12/1979"), 36);
            // Make this cope with a target age rather than a fixed date which will require test changed on 7/12/2016!!1
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
        public void WhenInvalidKeySelected_IsMaleReturnsNull()
        {
            ApplicantDetails foo = new ApplicantDetails();
            Assert.Null(foo.SetGender("herp"));
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
        public void WhenInvalidCharacterEnteredForSmoker_IsSmokerReturnsNull()
        {
            ApplicantDetails foo = new ApplicantDetails();
            Assert.Null(foo.SetSmoker("g"));
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

        [Test]
        public void WhenInvalidKeySelected_HasChildredIsNull()
        {
            ApplicantDetails foo = new ApplicantDetails();
            Assert.Null(foo.SetChildren("p"));
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
    }
}