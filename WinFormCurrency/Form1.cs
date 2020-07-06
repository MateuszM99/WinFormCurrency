using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCurrency
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        
        public static Form1 Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

       public Panel pnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        

        public Form1()
        {
            InitializeComponent();
        }
                           
        private void MMCurrency_Click(object sender, EventArgs e)
        {

        }
                       
        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            HomeForm hf = new HomeForm();
            hf.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(hf);

        }      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.pnlContainer.Controls.ContainsKey("HomeForm"))
            {
                HomeForm hf = new HomeForm();
                hf.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(hf);
            }
            
            Form1.Instance.pnlContainer.Controls["HomeForm"].BringToFront();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
