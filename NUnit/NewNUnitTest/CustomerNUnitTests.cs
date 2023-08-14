using ClassLibrary1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Customer;

namespace NewNUnitTest
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        private Customer customer;
        [SetUp]
        public void SetUp()
        {
            customer = new Customer();  //TO MAKE IT GLOBAL
        }
        [Test]
        [TestCase("Shubham", "Dubey")]
        public void CombineName(string Fname, string LName)
        {
            //Arrange
            //var res = customer.CombineNames(Fname, LName);
            //Act
            string res = customer.CombineNames(Fname, LName);
            //Assert
            Assert.That(res, Is.EqualTo("Shubham Dubey"));
            Assert.AreEqual(res, "Shubham Dubey");
            Assert.That(res, Does.Contain("s").IgnoreCase);
            Assert.That(res, Does.StartWith("S"));
            Assert.That(res, Does.EndWith("y"));
            Assert.That(res, Does.Match("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));
        }
        [Test]
        public void CheckNull()
        {
            //Arrange
            //var customer = new Customer();
            //Act
            //Assert
            Assert.IsNull(customer.GreetMessage);
        }
        [Test]
        public void OddRanger() 
        {
            //Arrange
            List<int> expectedOddRange = new() { 5, 7, 9 }; // 5, 10;
            var calc = new Calculator();

            //Act
            List<int> result = calc.GetOddRange(5, 10);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EquivalentTo(expectedOddRange));
                //Assert.AreEqual(expectedOddRange, result);
                //Assert.Contains(7,result);
                Assert.That(result, Does.Contain(7));
                Assert.That(result, Is.Not.Empty);
                Assert.That(result.Count, Is.EqualTo(3));
                Assert.That(result, Has.No.Member(6));
                Assert.That(result, Is.Ordered);
                Assert.That(result, Is.Unique);
            });
        }
        [Test]
        public void Discount_check()
        {
            int result = customer.Discount;
            Assert.That(result, Is.InRange(10, 25));
        }

        [Test]
        public void CheckException()
        {
            // Check with Exception Message
            var exceptionDetails = Assert.Throws<ArgumentException>(()=>customer.CombineNames("" , "Spark"));
            //Assert.AreEqual("Empty First Name", exceptionDetails.Message);
            Assert.That(() => customer.CombineNames("", "Spark"), Throws.Exception.With.Message.EqualTo("Empty First Name"));

            //Check Withot Exception Message
            Assert.Throws<ArgumentException>(() => customer.CombineNames("", "Spark"));
            Assert.That(() => customer.CombineNames("", "Spark"), Throws.ArgumentException);
        }
        [Test]
        public void Basic_CustomerType() 
        {
            customer.OrderTotal = 10;
            var result = customer.GetCustomerDetails();
            Assert.That(result , Is.TypeOf<BasicCustomer>());
        }
        [Test]
        public void Patinum_CustomerType() 
        {
            customer.OrderTotal = 110;
            var result = customer.GetCustomerDetails();
            Assert.That(result , Is.TypeOf<PlatinumCustomer>());
        }
    }
}
