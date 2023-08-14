﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private double Price { get; set; }
        public double getPrice(Customer customer)
        {
            if(customer.IsPlatinum)
            {
                return Price* .8;
            }
            return Price;
        }
    }
}
