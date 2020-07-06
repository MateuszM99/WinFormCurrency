using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WinFormCurrency.IServices;
using WinFormCurrency.Models;

namespace WinFormCurrency.Services
{
    public class CurrencyServices : ICurrencyServices
    {
        private HashSet<string> neededCurrencies = new HashSet<string>
        {
            "ALL","AMD","AZN","BAM","BGN","BYN","BZD","CHF","CNY","CZK","DKK",
            "EUR","FJD","GBP","GEL","HRK","HUF","IDR","ILS","ISK","KGS","KZT",
            "LKR","MDL","MKD","NOK","PLN","RON","RSD","RUB","SEK","TJS","TRY",
            "UAH","USD"
        };
        public List<Currency> GetAllCurrencies()
        {
            List<Currency> currencies = new List<Currency>();

            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));

            var xml1 = client.GetStringAsync("http://api.nbp.pl/api/exchangerates/tables/A/").GetAwaiter().GetResult();
            var xml2 = client.GetStringAsync("http://api.nbp.pl/api/exchangerates/tables/B/").GetAwaiter().GetResult();

            XDocument doc1 = XDocument.Parse(xml1);
            XDocument doc2 = XDocument.Parse(xml2);

            AddCurrenciesToList(doc1, currencies);
            AddCurrenciesToList(doc2, currencies);

            return currencies;
        }

        public List<Currency> GetAllCurrencies(DateTime cDate)
        {
            List<Currency> currencies = new List<Currency>();

            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));
            string stringDate = DateFormatting(cDate);
            string url1 = String.Format("http://api.nbp.pl/api/exchangerates/tables/A/{0}", stringDate);
            string url2 = String.Format("http://api.nbp.pl/api/exchangerates/tables/B/{0}", stringDate);
            string xml1 = null;
            string xml2 = null;

            while (true)
            {
                try
                {
                    xml1 = client.GetStringAsync(url1).GetAwaiter().GetResult();
                }
                catch (System.Net.Http.HttpRequestException)
                {

                }

                if (xml1 != null)
                    break;

                cDate = cDate.Subtract(TimeSpan.FromDays(1));
                stringDate = DateFormatting(cDate);
                url1 = String.Format("http://api.nbp.pl/api/exchangerates/tables/A/{0}", stringDate);

            }

            while (true)
            {
                try
                {
                    xml2 = client.GetStringAsync(url2).GetAwaiter().GetResult();
                }
                catch (System.Net.Http.HttpRequestException)
                {

                }

                if (xml2 != null)
                    break;

                cDate = cDate.Subtract(TimeSpan.FromDays(1));
                stringDate = DateFormatting(cDate);
                url2 = String.Format("http://api.nbp.pl/api/exchangerates/tables/B/{0}", stringDate);

            }
            

            XDocument doc1 = XDocument.Parse(xml1);
            XDocument doc2 = XDocument.Parse(xml2);

            AddCurrenciesToList(doc1, currencies);
            AddCurrenciesToList(doc2, currencies);

            return currencies;
        }

        private string DateFormatting(DateTime date)
        {
            string formatted = null;

            if(date.Month < 10 && date.Day < 10)
            formatted = date.Year + "-0" + date.Month + "-0" + date.Day;

            if (date.Month < 10 && date.Day >= 10)
            formatted = date.Year + "-0" + date.Month + "-" + date.Day;

            if (date.Month >= 10 && date.Day < 10)
            formatted = date.Year + "-" + date.Month + "-0" + date.Day;

            if (date.Month >= 10 && date.Day >= 10)
            formatted = date.Year + "-" + date.Month + "-" + date.Day;

            return formatted;
        }

       private void AddCurrenciesToList(XDocument doc,List<Currency> currencies)
       {
            string date = doc.Descendants().SingleOrDefault(p => p.Name.LocalName == "EffectiveDate").Value;

            foreach (XElement element in doc.Descendants("Rates").Descendants("Rate"))
            {
                if (neededCurrencies.Contains(element.Element("Code").Value))
                {

                    Currency currency = new Currency();

                    currency.CurrencyName = element.Element("Currency").Value;

                    currency.CurrencyCode = element.Element("Code").Value;

                    currency.AverageExchangeRate = element.Element("Mid").Value;


                    currency.Date = date;

                    currencies.Add(currency);
                }
            }



        }


    }
}
