using System;
using System.Collections.Generic;
using System.Text;

namespace StockPrices.Data
{
    public class StockList
    {
        public List<Stock> stocklist { get; set; }
        public StockList()
        {
            stocklist = new List<Stock>();
            stocklist.Add(
                new Stock
                {
                    Ticker = "APPL",
                    FullName = "Apple.inc",
                    Price = 119.84
                }
            );
        }
    }
}
