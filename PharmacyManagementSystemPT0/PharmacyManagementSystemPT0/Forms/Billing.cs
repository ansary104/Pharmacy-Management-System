using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;


namespace PharmacyManagementSystemPT0.Forms
{
    public partial class Billing : Form
    {
        Boolean var = false;
        String str;

        public string connection_Str = "Data Source=.\\sqlexpress;Data Source=DESKTOP-EVASEB4;Initial Catalog=PharmacyManagementSystem;Integrated Security=True";
        private SqlConnection conn;

        DAO_Class.StockDAO stockDao = new DAO_Class.StockDAO();
        //DAO_Class.BillingDAO billingDao = new DAO_Class.BillingDAO();

        public Billing()
        {
            InitializeComponent();
            loadBilling();
        }

        private void loadBilling()
        {
            if (var == false)
                StockInformation.DataSource = stockDao.GetStockByOrder().Tables[0];
            else
                StockInformation.DataSource = stockDao.SearchStocks(str).Tables[0];



            var = false;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            var = true;
            str = SearchBox.Text;
            loadBilling();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Medquantity1Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Amount2Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MednameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MakeBill_Click(object sender, EventArgs e)
        {
            createBilling();
        }

        private void Medquantity2Box_TextChanged(object sender, EventArgs e)
        {

        }
 

        private void createBilling()
        {


           try
            {
                conn = new SqlConnection(connection_Str);


                int billid = Convert.ToInt32(BillIDBox.Text);
                string date = DateBox.Text;
                string salesid = SalesmanIDBox.Text;
                string custname = CustomerNameBox.Text;
                string docname = DoctorNameBox.Text;
                int presid = Convert.ToInt32(PrescriptionIDBox.Text);
                string med1n = MednameBox.Text;
                string med2n = Medname1Box.Text;
                string med3n = Medname2Box.Text;
                float med1q = 0;
                float med2q = 0;
                float med3q = 0;

                float amount = 0, amount1 = 0, amount2 = 0, amount3 = 0;


                string med1n_f = "", med2n_f = "", med3n_f = "";


                float medicine1_nextquantity = 0, medicine2_nextquantity = 0, medicine3_nextquantity = 0;

                conn = new SqlConnection(connection_Str);


                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Stock where MedicineName ='" + med1n + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);



                if (dt.Rows[0][0].ToString() == "1")
                {
                    med1q = float.Parse(MedquantityBox.Text);
                    med1n_f = med1n;

                    SqlDataAdapter sda1 = new SqlDataAdapter("select Price from Stock where MedicineName ='" + med1n_f + "'", conn);
                    SqlDataAdapter sda7 = new SqlDataAdapter("select Quantity from Stock where MedicineName ='" + med1n_f + "'", conn);

                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    string price1 = dt1.Rows[0][0].ToString();
                    float price_1 = float.Parse(price1);





                    DataTable dt7 = new DataTable();
                    sda7.Fill(dt7);
                    string current_quantity_med_1 = dt7.Rows[0][0].ToString();
                    float current_quantity_med1 = float.Parse(current_quantity_med_1);

                    amount1 = med1q * price_1;
                    medicine1_nextquantity = current_quantity_med1 - med1q;





                }
                else
                {
                    med1n_f = "";
                    amount1 = 0;
                }



                SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from Stock where MedicineName ='" + med2n + "'", conn);
                DataTable dt3 = new DataTable();

                sda3.Fill(dt3);



                if (dt3.Rows[0][0].ToString() == "1")
                {
                    med2n_f = med2n; med2q = float.Parse(Medquantity1Box.Text);

                    SqlDataAdapter sda4 = new SqlDataAdapter("select Price from Stock where MedicineName ='" + med2n_f + "'", conn);
                    SqlDataAdapter sda8 = new SqlDataAdapter("select Quantity from Stock where MedicineName ='" + med2n_f + "'", conn);

                    DataTable dt4 = new DataTable();
                    sda4.Fill(dt4);
                    string price2 = dt4.Rows[0][0].ToString();
                    float price_2 = float.Parse(price2);





                    DataTable dt8 = new DataTable();
                    sda8.Fill(dt8);
                    string current_quantity_med_2 = dt8.Rows[0][0].ToString();
                    float current_quantity_med2 = float.Parse(current_quantity_med_2);


                    amount2 = med2q * price_2;
                    medicine2_nextquantity = current_quantity_med2 - med2q;





                }
                else
                {
                    med2n_f = "";
                    amount2 = 0;
                }


                SqlDataAdapter sda5 = new SqlDataAdapter("select count(*) from Stock where MedicineName ='" + med3n + "'", conn);

                DataTable dt5 = new DataTable();

                sda5.Fill(dt5);



                if (dt5.Rows[0][0].ToString() == "1")
                {
                    med3n_f = med3n; med3q = float.Parse(Medquantity2Box.Text);

                    SqlDataAdapter sda6 = new SqlDataAdapter("select Price from Stock where MedicineName ='" + med3n_f + "'", conn);
                    SqlDataAdapter sda9 = new SqlDataAdapter("select Quantity from Stock where MedicineName ='" + med3n_f + "'", conn);

                    DataTable dt6 = new DataTable();
                    sda6.Fill(dt6);
                    string price3 = dt6.Rows[0][0].ToString();
                    float price_3 = float.Parse(price3);


                    DataTable dt9 = new DataTable();
                    sda9.Fill(dt9);
                    string current_quantity_med_3 = dt9.Rows[0][0].ToString();
                    float current_quantity_med3 = float.Parse(current_quantity_med_3);

                    amount3 = med3q * price_3;
                    medicine3_nextquantity = current_quantity_med3 - med3q;





                }
                else
                {
                    med3n_f = "";
                    amount3 = 0;
                }

                amount = amount1 + amount2 + amount3;

                TotalamountBox.Text = amount.ToString();

                SqlConnection sqlConnection104 = new SqlConnection(connection_Str);
                sqlConnection104.Open();

                string sqlQuery104 = " insert into Bill values('" + billid +
                                                                   "','" + presid +
                                                                   "','" + salesid +
                                                                   "','" + custname +
                                                                   "','" + date +
                                                                   "','" + med1n_f +
                                                                   "','" + med2n_f +
                                                                   "','" + med3n_f +
                                                                   "','" + med1q +
                                                                   "','" + med2q +
                                                                   "','" + med3q +
                                                                   "','" + amount +
                                                                   "','" + docname +
                                                                    "')";


                SqlCommand sqlCommand104 = new SqlCommand(sqlQuery104, sqlConnection104);
                sqlCommand104.ExecuteNonQuery();


                string sqlQuery20 = "Update Stock SET Quantity='" + medicine1_nextquantity + "' where MedicineName='" + med1n_f + "'";
                SqlCommand sqlCommand20 = new SqlCommand(sqlQuery20, sqlConnection104);
                sqlCommand20.ExecuteNonQuery();

                string sqlQuery21 = "Update Stock SET Quantity='" + medicine2_nextquantity + "' where MedicineName='" + med2n_f + "'";
                SqlCommand sqlCommand21 = new SqlCommand(sqlQuery21, sqlConnection104);
                sqlCommand21.ExecuteNonQuery();


                string sqlQuery22 = "Update Stock SET Quantity='" + medicine2_nextquantity + "' where MedicineName='" + med3n_f + "'";
                SqlCommand sqlCommand22 = new SqlCommand(sqlQuery22, sqlConnection104);
                sqlCommand22.ExecuteNonQuery();

                sqlConnection104.Close();

            }
            catch( Exception ex)
            {
                MessageBox.Show("Invalid Input!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /* pdf */

            String s_t_r = BillIDBox.Text;

            //      String s_t_r_1 = s_t_r + ".pdf";
            //  C: \Users\user\Desktop\Billing

            String s_t_r_1 = "C://Users//user//Desktop//Billing//" + s_t_r + ".pdf";



            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 70, 70, 70, 70);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(s_t_r_1, FileMode.Create));
            doc.Open();
            Paragraph paragragh;

            paragragh = new Paragraph("Bill Id:" + BillIDBox.Text);
            doc.Add(paragragh);

            paragragh = new Paragraph("Date:" + DateBox.Text);
            doc.Add(paragragh);

            paragragh = new Paragraph(""); doc.Add(paragragh);
            paragragh = new Paragraph(""); doc.Add(paragragh);
            paragragh = new Paragraph(""); doc.Add(paragragh);
            paragragh = new Paragraph(""); doc.Add(paragragh);

            paragragh = new Paragraph("Customer Name:" + CustomerNameBox.Text);
            doc.Add(paragragh);

            paragragh = new Paragraph(""); doc.Add(paragragh);
            paragragh = new Paragraph(""); doc.Add(paragragh);
            paragragh = new Paragraph(""); doc.Add(paragragh);

            paragragh = new Paragraph("Medicine:");
            doc.Add(paragragh);

            paragragh = new Paragraph("Name:" + MednameBox.Text + "       Quantity:" + MedquantityBox.Text);
            doc.Add(paragragh);

            paragragh = new Paragraph("Name:" + Medname1Box.Text + "      Quantity:" + Medquantity1Box.Text);
            doc.Add(paragragh);

            paragragh = new Paragraph("Name:" + Medname2Box.Text + "      Quantity:" + Medquantity2Box.Text);
            doc.Add(paragragh);


            paragragh = new Paragraph(""); doc.Add(paragragh);
            paragragh = new Paragraph(""); doc.Add(paragragh);

            paragragh = new Paragraph("Total Amount: " + TotalamountBox.Text + "tk");
            doc.Add(paragragh);

            paragragh = new Paragraph(""); doc.Add(paragragh);
            paragragh = new Paragraph(""); doc.Add(paragragh);
            paragragh = new Paragraph("Salesman Id:" + SalesmanIDBox.Text);
            doc.Add(paragragh);



            doc.Close();

            /* pdf */









            loadBilling();

        }

        private void SalesmanIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            SalesmanHomePage shp = new SalesmanHomePage();
            this.Hide();
            shp.ShowDialog();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            BillIDBox.Text = String.Empty; ;
            DateBox.Text = String.Empty; ;
            SalesmanIDBox.Text = String.Empty; ;
            CustomerNameBox.Text = String.Empty; ;
            DoctorNameBox.Text = String.Empty; ;
            PrescriptionIDBox.Text = String.Empty; ;
            MednameBox.Text = String.Empty; ;
            Medname1Box.Text = String.Empty; ;
            Medname2Box.Text = String.Empty; ;
            MedquantityBox.Text = String.Empty; ;
            Medquantity1Box.Text = String.Empty; ;
            Medquantity2Box.Text = String.Empty; ;
            TotalamountBox.Text = String.Empty; ;
            SearchBox.Text = String.Empty;

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BillIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
