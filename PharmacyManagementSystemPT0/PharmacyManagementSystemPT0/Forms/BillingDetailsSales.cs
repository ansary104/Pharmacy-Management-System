using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystemPT0.Forms
{
    public partial class BillingDetailsSales : Form
    {
        Boolean var = false;
        String str;

        DAO_Class.BillDAO billDao = new DAO_Class.BillDAO();

      
          
        public BillingDetailsSales()
        {
            InitializeComponent();
            loadBills();
        }

        private void loadBills()
        {

            if (var == false)
                BillInfo.DataSource = billDao.GetBills().Tables[0];
            else

                BillInfo.DataSource = billDao.SearchBills(str).Tables[0];

            var = false;

        }
        private void Search_Click(object sender, EventArgs e)
        {
            var = true;
            str = SearchBox.Text;
            loadBills();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            SearchBox.Text = String.Empty;

            var = false;
            loadBills();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            SalesmanHomePage shp = new SalesmanHomePage();
            this.Hide();
            shp.ShowDialog();
        }
    }
}
