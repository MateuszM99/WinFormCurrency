using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinFormCurrency.Models
{
    public class Currency
    {

        public string CurrencyName { get; set; }

        public string CurrencyCode { get; set; }

        public string AverageExchangeRate { get; set; }

        public string Date { get; set; }

    }
}