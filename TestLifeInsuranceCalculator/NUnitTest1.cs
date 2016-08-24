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
        }

        [Test]
        public void TestAgeCalculated_WhenBirthdayIsLaterInYear()
        {
            DateOfBirth DOB = new DateOfBirth();
            Assert.AreEqual(DOB.CalculateAgeFromDOB("31/12/1979"), 36);
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

        //TODO Add tests for children being added
    }
}