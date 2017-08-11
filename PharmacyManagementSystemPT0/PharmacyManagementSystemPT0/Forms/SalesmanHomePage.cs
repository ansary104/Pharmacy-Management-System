using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystemPT0
{
    public partial class SalesmanHomePage : Form
    {
        public SalesmanHomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.Billing sd = new Forms.Billing();
            this.Hide();
            sd.ShowDialog();
        }

        private void BillingDetails_Click(object sender, EventArgs e)
        {
            Forms.BillingDetailsSales bd2 = new Forms.BillingDetailsSales();
            this.Hide();
            bd2.ShowDialog();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            Forms.StockDetails sd = new Forms.StockDetails();
            this.Hide();
            sd.ShowDialog();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
            this.Hide();
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
