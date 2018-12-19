using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockPrices.Models
{
    public class Stock
    {
        public string Value { get; set; }
        public double Price { get { return 50.65 ; } }
    }
}