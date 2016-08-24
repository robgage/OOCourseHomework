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
    }
}