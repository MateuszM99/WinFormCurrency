using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Guna.UI2.WinForms.Helpers;
using Guna.UI2.WinForms;
using System.Drawing.Imaging;
using WinFormCurrency.Models;
using WinFormCurrency.IServices;
using WinFormCurrency.Services;

namespace WinFormCurrency
{
    public partial class CurrencyTable : UserControl
    {
        List<Currency> _currencies;
        public CurrencyTable(List<Currency> currencies)
        {
            _currencies = currencies;
            InitializeComponent();
        }
            
       

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            

            foreach(var i in _currencies)
            {
                CurrencyList cl = new CurrencyList();
                cl.Dock = DockStyle.Top;
                cl.list_CurrencyN = i.CurrencyName;
                cl.list_CurrencyC = i.CurrencyCode;
                cl.list_CurrencyM = i.AverageExchangeRate;
                cl.list_CurrencyD = i.Date;
                guna2Panel2.Controls.Add(cl);
            }
        }
    }
}
