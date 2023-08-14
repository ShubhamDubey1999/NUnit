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
    public class FiboTest
    {
        private Fibo? fibo;
        [SetUp]
        public void SetUp()
        {
            fibo = new Fibo();
        }
        //[Test]
        //[TestCase(1)]
        public void RangeTest(int a)
        {
            List<int> expectedRange = new() { 0 };
            fibo.Range = a;
            List<int> result = fibo.GetFiboSeries();
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.Ordered);
            Assert.AreEqual(expectedRange, Is.EquivalentTo(result));
        }
        [TestCase(6)]
        public void RangeTest2(int a)
        {
            List<int> expectedRange = new() { 0, 1, 1, 2, 3, 5 };
            fibo.Range = a;
            List<int> result = fibo.GetFiboSeries();
            //Assert.AreEqual(expectedRange.Count, result);
            Assert.AreEqual(expectedRange, result);
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Has.No.Member(4));
            Assert.That(result.Count, Is.EqualTo(6));
        }
    }
}
