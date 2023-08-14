using ClassLibrary1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNUnitTest
{
    [TestFixture]
    public class TestGradingCalculator
    {
        private GradingCalculator gradingCalculator;
        [SetUp]
        public void SetUp()
        {
            gradingCalculator = new GradingCalculator();
        }
        [Test]
        [TestCase(95, 90 , ExpectedResult ="A")]
        [TestCase(85, 90, ExpectedResult = "B")]
        [TestCase(65, 90, ExpectedResult = "C")]
        [TestCase(95, 65, ExpectedResult = "B")]
        [TestCase(95, 55, ExpectedResult = "F")]
        [TestCase(65, 55, ExpectedResult = "F")]
        [TestCase(50, 90, ExpectedResult = "F")]
        public string CheckGrade(int a, int b)
        {
            //Arrange
            gradingCalculator.Score = a;
            gradingCalculator.AttendancePercentage = b;
            //Act
            //string result = gradingCalculator.GetGrade();
            //Assert
            return gradingCalculator.GetGrade();
            //Assert.Multiple(() =>
            //{
            //    Assert.That(result, Is.EqualTo("A"));
            //    Assert.That(result, Is.EqualTo("B"));
            //    Assert.That(result, Is.EqualTo("C"));
            //    Assert.That(result, Is.EqualTo("B"));
            //    Assert.That(result, Is.EqualTo("F"));
            //    Assert.That(result, Is.EqualTo("F"));
            //    Assert.That(result, Is.EqualTo("F"));
            //});
        }
    }
}
