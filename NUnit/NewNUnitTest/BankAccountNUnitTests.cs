using ClassLibrary1;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNUnitTest
{
    [TestFixture]
    public class BankAccountNUnitTests
    {
        private BankAccount bankAccount;
        [SetUp]
        public void setup()
        {
            //bankAccount = new(new LogBook());
        }
        [Test]
        public void BankDepositAdd100_returnTrue()
        {
            var logMock = new Mock<ILogBook>();
            //logMock.Setup(x => x.Message(""));
            BankAccount bankAccount = new(logMock.Object);
            var result = bankAccount.Deposit(100);
            Assert.IsTrue(result);
            Assert.That(bankAccount.GetBalance, Is.EqualTo(100));
        }
    }
}
