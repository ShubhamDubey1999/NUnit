using ClassLibrary1;
using NUnit.Framework;

namespace NewNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers()
        {
            //Arrange
            //Calculator calc = new(); //Not Arranging because we have made the method static

            //Act 
            int result = Calculator.AddNumbers(10, 20);

            //Assert
            Assert.AreEqual(30, result);
        }
        //[Test]
        //[TestCase(1)]
        //[TestCase(13)]
        //[TestCase(12)]
        //public void IsOddNumber(int a) 
        //{
        //    bool reult = Calculator.IsOddNumber(a);
        //    //Assert.That(reult, Is.EqualTo(true));
        //    Assert.IsTrue(reult);
        //}

        [Test]
        [TestCase(10 , ExpectedResult =true)]
        [TestCase(11 , ExpectedResult =false)]
        public bool IsOddNumber(int a)
        {
            //bool reult = Calculator.IsOddNumber(a);
            return Calculator.IsOddNumber(a);
            //Assert.That(reult, Is.EqualTo(true));
            //Assert.IsTrue(reult);
        }
        [Test]
        [TestCase(5.4 ,10.5)]
        [TestCase(5.3 ,10.2)]
        [TestCase(5.1 ,10.4)]
        public void AddDoubles(double a , double b)
        {
            double result  = Calculator.AddDoubles(a, b);
            Assert.AreEqual(15.9, result , 1);
        }
    }
}