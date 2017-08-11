using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyManagementSystemPT0
{
    public partial class SalesmanLDB : Form
    {
        Boolean var = false;
        String str;


        SalesmanDAO salesmanDao = new SalesmanDAO();

        public SalesmanLDB()
        {
            InitializeComponent();
            loadSalesmans();
        }

        private void loadSalesmans()
        {

            if (var == false)
                SalesmanInfo.DataSource = salesmanDao.GetSalesmans().Tables[0];
            else
                
                SalesmanInfo.DataSource = salesmanDao.SearchSalesmans(str).Tables[0];

            var = false;

        }

        private void createSalesman()
        {
            try
            {
                int id = Convert.ToInt32(IDBox.Text);
                string name = NameBox.Text;
                string password = PasswordBox.Text;
                string address = AddressBox.Text;


                salesmanDao.CreateSalesman(new SalesmanDTO(id, name, password, address));

                loadSalesmans();

            }

            catch( Exception ex)
            {
                MessageBox.Show("Incomplete Input!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            OwnerIF f3 = new OwnerIF();
            this.Hide();
            f3.ShowDialog();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.\\sqlexpress;Data Source=DESKTOP-EVASEB4;Initial Catalog=PharmacyManagementSystem;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Salesman where SalesmanName ='" + NameBox.Text + "' and Password='" + PasswordBox.Text + "'", conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Username , Password already exist!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                createSalesman();
            }
        }


        private void deleteSalesman()
        {
            salesmanDao.DeleteSalesman(Convert.ToInt32(IDBox.Text));

            loadSalesmans();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            deleteSalesman();
        }

        private void updateSalesman()
        {
            int id = Convert.ToInt32(IDBox.Text);
            string name = NameBox.Text;
            string password = PasswordBox.Text;
            string address = AddressBox.Text;

            salesmanDao.UpdateSalesman(new SalesmanDTO(id, name, password, address));

            loadSalesmans();

        }

        private void Upadate_Click(object sender, EventArgs e)
        {
            updateSalesman();
        }

        private void SalesmanInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalesmanInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (SalesmanInfo.SelectedRows.Count == 1)

            {
                int idx = SalesmanInfo.SelectedRows[0].Index;

                IDBox.Text = SalesmanInfo.Rows[idx].Cells[0].Value.ToString();
                NameBox.Text = SalesmanInfo.Rows[idx].Cells[1].Value.ToString();
                PasswordBox.Text = SalesmanInfo.Rows[idx].Cells[2].Value.ToString();
                AddressBox.Text = SalesmanInfo.Rows[idx].Cells[3].Value.ToString();


            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            IDBox.Text = String.Empty;
            NameBox.Text = String.Empty;
            PasswordBox.Text = String.Empty;
            AddressBox.Text = String.Empty;
            SearchBox.Text = String.Empty;

            var = false;
            loadSalesmans();

        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            var = true;
            str = SearchBox.Text;
            loadSalesmans();
        }
    }
}
