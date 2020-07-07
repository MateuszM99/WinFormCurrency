using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormCurrency.IServices;
using WinFormCurrency.Models;
using WinFormCurrency.Services;

namespace WinFormCurrency
{
    public partial class HomeForm : UserControl
    {
        
        public HomeForm()
        {           
            InitializeComponent();
        }

        private void guna2Separator3_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            CurrentDate.Text = DateTime.Now.ToString();
            DateTimePicker.MaxDate = DateTime.Now;
            DateTimePicker.MinDate = new DateTime(2002, 1, 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.pnlContainer.Controls.RemoveByKey("CurrencyTable");

           // if (!Form1.Instance.pnlContainer.Controls.ContainsKey("CurrencyTable"))
          //  {
                CurrencyServices currencyServices = new CurrencyServices();
                List<Currency> _currencies = currencyServices.GetAllCurrencies();
                CurrencyTable ct = new CurrencyTable(_currencies);
                ct.Dock = DockStyle.Fill;
                Form1.Instance.pnlContainer.Controls.Add(ct);
                
           // }

            Form1.Instance.pnlContainer.Controls["CurrencyTable"].BringToFront();


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1.Instance.pnlContainer.Controls.RemoveByKey("CurrencyTable");
            // if (!Form1.Instance.pnlContainer.Controls.ContainsKey("CurrencyTable"))
            //    {
                CurrencyServices currencyServices = new CurrencyServices();               
                List<Currency> _currencies = currencyServices.GetAllCurrencies(DateTimePicker.Value);
                CurrencyTable ct = new CurrencyTable(_currencies);
                ct.Dock = DockStyle.Fill;
                Form1.Instance.pnlContainer.Controls.Add(ct);

          //  }
            
            Form1.Instance.pnlContainer.Controls["CurrencyTable"].BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mateusz-m%C5%82odochowski-b9abb11aa/");
        }
    }
}
