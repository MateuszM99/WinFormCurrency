using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WinFormCurrency.IServices;
using WinFormCurrency.Models;

namespace WinFormCurrency.Services
{
   public class CurrencyServices : ICurrencyServices
    {
        public List<Currency> GetAllCurrencies()
        {
            List<Currency> currencies = new List<Currency>();

            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));

            var xml = client.GetStringAsync("http://api.nbp.pl/api/exchangerates/tables/A/").GetAwaiter().GetResult();


            XDocument doc = XDocument.Parse(xml);

            string date = doc.Descendants().SingleOrDefault(p => p.Name.LocalName == "EffectiveDate").Value;

            foreach (XElement element in doc.Descendants("Rates").Descendants("Rate"))
            {

                Currency currency = new Currency();

                currency.CurrencyName = element.Element("Currency").Value;

                currency.CurrencyCode = element.Element("Code").Value;

                currency.AverageExchangeRate = element.Element("Mid").Value;


                currency.Date = date;

                currencies.Add(currency);

            }

            return currencies;
        }

        public List<Currency> GetAllCurrencies(string cDate)
        {
            List<Currency> currencies = new List<Currency>();

            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));
            string url = String.Format("http://api.nbp.pl/api/exchangerates/tables/A/{0}", cDate);

            var xml = client.GetStringAsync(url).GetAwaiter().GetResult();


            XDocument doc = XDocument.Parse(xml);

            string date = doc.Descendants().SingleOrDefault(p => p.Name.LocalName == "EffectiveDate").Value;

            foreach (XElement element in doc.Descendants("Rates").Descendants("Rate"))
            {

                Currency currency = new Currency();

                currency.CurrencyName = element.Element("Currency").Value;

                currency.CurrencyCode = element.Element("Code").Value;

                currency.AverageExchangeRate = element.Element("Mid").Value;


                currency.Date = date;

                currencies.Add(currency);

            }

            return currencies;
        }

        public string DateFormatting(DateTime date)
        {
            string formatted = null;

            if(date.Month < 10 && date.Day < 10)
            formatted = date.Year + "-0" + date.Month + "-0" + date.Day;

            if (date.Month < 10 && date.Day > 10)
            formatted = date.Year + "-0" + date.Month + "-" + date.Day;

            if (date.Month > 10 && date.Day < 10)
            formatted = date.Year + "-" + date.Month + "-0" + date.Day;

            if (date.Month > 10 && date.Day > 10)
            formatted = date.Year + "-" + date.Month + "-" + date.Day;

            return formatted;
        }
    }
}
