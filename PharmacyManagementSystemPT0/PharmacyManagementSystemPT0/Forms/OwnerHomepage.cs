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
    public partial class OwnerIF : Form
    {
        public OwnerIF()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
            this.Hide();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerLDB f4 = new OwnerLDB();
            this.Hide();
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalesmanLDB sl = new SalesmanLDB();
            this.Hide();
            sl.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.Transaction ot = new Forms.Transaction();
            this.Hide();
            ot.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.StockDetails sd = new Forms.StockDetails();
            this.Hide();
            sd.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Forms.Billing sd = new Forms.Billing();
            this.Hide();
            sd.ShowDialog();
        }

        private void DetailsBilling_Click(object sender, EventArgs e)
        {
            Forms.BillingDetails bd1 = new Forms.BillingDetails();
            this.Hide();
            bd1.ShowDialog();
        }
    }
}
