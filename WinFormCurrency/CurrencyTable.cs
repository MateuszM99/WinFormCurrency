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

        



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CurrencyTable_Load(object sender, EventArgs e)
        {
            foreach (var i in _currencies)
            {
                dataGridView1.Rows.Add(
                new object[]
                {
                i.CurrencyName,
                i.CurrencyCode,
                i.AverageExchangeRate,
                i.Date
                });
            }
        }
    }
}
