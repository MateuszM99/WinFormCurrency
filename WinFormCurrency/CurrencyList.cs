using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCurrency
{
    public partial class CurrencyList : UserControl
    {
        public string list_CurrencyN
        {
            get
            {
                return this.list_currencyN.Text;
            }
            set
            {
                this.list_currencyN.Text = value;
            }
        }

        public string list_CurrencyC
        {
            get
            {
                return this.list_currencyC.Text;
            }
            set
            {
                this.list_currencyC.Text = value;
            }
        }
        public string list_CurrencyM
        {
            get
            {
                return this.list_currencyM.Text;
            }
            set
            {
                this.list_currencyM.Text = value;
            }
        }
        public string list_CurrencyD
        {
            get
            {
                return this.list_currencyD.Text;
            }
            set
            {
                this.list_currencyD.Text = value;
            }
        }





        public CurrencyList()
        {
            InitializeComponent();
        }

        private void CurrencyList_Load(object sender, EventArgs e)
        {

        }

        private void list_currencyN_Click(object sender, EventArgs e)
        {
            
        }
    }
}
