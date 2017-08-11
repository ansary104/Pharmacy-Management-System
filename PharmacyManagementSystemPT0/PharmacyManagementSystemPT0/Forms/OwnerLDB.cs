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
    public partial class OwnerLDB : Form
    {
        Boolean var = false;
        String str;


        OwnerDAO ownerDao = new OwnerDAO();


        public OwnerLDB()
        {
            InitializeComponent();
            loadOwners();
        }

        private void loadOwners()
        {
            if (var == false)
                OwnerInfo.DataSource = ownerDao.GetOwners().Tables[0];
            else
                OwnerInfo.DataSource = ownerDao.SearchOwners(str).Tables[0];

            var = false;
        }

        private void createOwner()
        {
            int id = Convert.ToInt32(IDBox.Text);
            string name = NameBox.Text;
            string password = PasswordBox.Text;


            ownerDao.CreateOwner(new OwnerDTO(id, name, password));

            loadOwners();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string str = "Data Source=.\\sqlexpress;Data Source=DESKTOP-EVASEB4;Initial Catalog=PharmacyManagementSystem;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Owner where OwnerName ='" + NameBox.Text + "' and Password='" + PasswordBox.Text + "'", conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Username , Password already exist!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                createOwner();
            }
            
        }

        private void deleteOwnerer()
        {
            ownerDao.DeleteOwner(Convert.ToInt32(IDBox.Text));

            loadOwners();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            deleteOwnerer();
        }

        private void updateOwner()
        {
            int id = Convert.ToInt32(IDBox.Text);
            string name = NameBox.Text;
            string password = PasswordBox.Text;

            ownerDao.UpdateOwner(new OwnerDTO(id, name, password));

            loadOwners();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                updateOwner();
                
        }


        private void OwnerInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (OwnerInfo.SelectedRows.Count == 1)
            {
                int idx = OwnerInfo.SelectedRows[0].Index;

                IDBox.Text = OwnerInfo.Rows[idx].Cells[0].Value.ToString();
                NameBox.Text = OwnerInfo.Rows[idx].Cells[1].Value.ToString();
                PasswordBox.Text = OwnerInfo.Rows[idx].Cells[2].Value.ToString();


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OwnerLDB_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OwnerIF f5 = new OwnerIF();
            this.Hide();
            f5.ShowDialog();

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IDBox.Text = String.Empty;
            NameBox.Text = String.Empty;
            PasswordBox.Text = String.Empty;
           // SearchBox.Text = String.Empty;

            var = false;
            loadOwners();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      /*  private void Search_Click(object sender, EventArgs e)
        {
            var = true;
            str = SearchBox.Text;
            loadOwners();
        }
*/
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
