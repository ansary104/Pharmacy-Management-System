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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            PasswordBox.PasswordChar = '*';
            PasswordBox.MaxLength = 5;
            comboBox2.Items.Add("Owner");
            comboBox2.Items.Add("Salesman");
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
          
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            About f2 = new About();
            this.Hide();
            f2.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            string str = "Data Source=.\\sqlexpress;Data Source=DESKTOP-EVASEB4;Initial Catalog=PharmacyManagementSystem;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);

            if(comboBox2.Text.ToString() == "Owner")
            {
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Owner where OwnerName ='" + textBox1.Text + "' and Password='" + PasswordBox.Text + "'", conn);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    OwnerIF f3 = new OwnerIF();
                    this.Hide();
                    f3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password or Usermode!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(comboBox2.Text.ToString() == "Salesman")
            {
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Salesman where SalesmanName ='" + textBox1.Text + "' and Password='" + PasswordBox.Text + "'", conn);

                DataTable dt1 = new DataTable();

                sda.Fill(dt1);

                if (dt1.Rows[0][0].ToString() == "1")
                {
                    SalesmanHomePage shp = new SalesmanHomePage();
                    this.Hide();
                    shp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password or Usermode!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wrong User Mode!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
