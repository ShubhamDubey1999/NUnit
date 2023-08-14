using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Customer
    {
        public int OrderTotal { get; set; }
        public int Discount = 15;
        public bool IsPlatinum { get; set; }
        public Customer()
        {
            IsPlatinum= false;
        }
        public string CombineNames(string FName, string LName)
        {
            if (string.IsNullOrWhiteSpace(FName))
            {
                throw new ArgumentException("Empty First Name");
            }
            Discount = 20;
            return $"{FName} {LName}";
        }
        public CustomerType GetCustomerDetails()
        {
            if (OrderTotal < 100)
            {
                return new BasicCustomer();
            }
            return new PlatinumCustomer();
        }

        public string GreetMessage { get; set; }
        public class CustomerType { }
        public class BasicCustomer:CustomerType { }
        public class PlatinumCustomer:CustomerType { }
    }
}
