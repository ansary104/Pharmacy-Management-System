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

namespace PharmacyManagementSystemPT0.Forms
{
    public partial class StockDetails : Form
    {
        Boolean var = false;
        String str;

        DAO_Class.StockDAO stockDao = new DAO_Class.StockDAO();

        public StockDetails()
        {
            InitializeComponent();
            loadStocks();
        }
        private void loadStocks()
        {

            if (var == false)
                StockInfo.DataSource = stockDao.GetStocks().Tables[0];
            else

                StockInfo.DataSource = stockDao.SearchStocks(str).Tables[0];

            var = false;

        }

        private void createStock()
        {
            try
            {
                int medicineid = Convert.ToInt32(IdBox.Text);
                string medicinename = NameBox.Text;
                float price = Convert.ToInt32(PriceBox.Text);
                int quantity = Convert.ToInt32(QuantityBox.Text);
                string medicinetype = TypeBox.Text;


         

                stockDao.CreateStock(new DTO_Class.StockDTO(medicineid, medicinename, price, quantity, medicinetype));

                loadStocks();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Incomplete Input!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void updateStock()
        {
            int medicineid = Convert.ToInt32(IdBox.Text);
            string medicinename = NameBox.Text;
            float price = Convert.ToInt32(PriceBox.Text);
            int quantity = Convert.ToInt32(QuantityBox.Text);
            string medicinetype = TypeBox.Text;

            stockDao.UpdateStock(new DTO_Class.StockDTO(medicineid, medicinename, price, quantity, medicinetype));

            loadStocks();
        }

        private void StockDetails_Load(object sender, EventArgs e)
        {

        }



        private void Create_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.\\sqlexpress;Data Source=DESKTOP-EVASEB4;Initial Catalog=PharmacyManagementSystem;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Stock where MedicineID ='" + IdBox.Text + "' and MedicineName = '" + NameBox.Text + "'", conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("This Medicine ID And Medicine already exist!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                createStock();
            }
        }


        private void Update_Click(object sender, EventArgs e)
        {
            updateStock();
        }


        private void deleteStock()
        {
            stockDao.DeleteStock(Convert.ToInt32(IdBox.Text));

            loadStocks();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            deleteStock();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            OwnerIF f3 = new OwnerIF();
            this.Hide();
            f3.ShowDialog();
        }


        private void StockInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (StockInfo.SelectedRows.Count == 1)
            {
                int idx = StockInfo.SelectedRows[0].Index;

                IdBox.Text = StockInfo.Rows[idx].Cells[0].Value.ToString();
                NameBox.Text = StockInfo.Rows[idx].Cells[1].Value.ToString();
                PriceBox.Text = StockInfo.Rows[idx].Cells[2].Value.ToString();
                QuantityBox.Text = StockInfo.Rows[idx].Cells[3].Value.ToString();
                TypeBox.Text = StockInfo.Rows[idx].Cells[4].Value.ToString();


            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var = true;
            str = SearchBox.Text;
            loadStocks();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            IdBox.Text = String.Empty;
            NameBox.Text = String.Empty;
            PriceBox.Text = String.Empty;
            QuantityBox.Text = String.Empty;
            TypeBox.Text = String.Empty;
            SearchBox.Text = String.Empty;

            var = false;
            loadStocks();
        }

        private void StockInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
