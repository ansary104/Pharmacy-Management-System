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
    public partial class Transaction : Form
    {

        Boolean var = false;
        String str;


        DAO_Class.TransactionDAO transactionDao = new DAO_Class.TransactionDAO();

        public Transaction()
        {
            InitializeComponent();
            loadTransactions();
        }


        private void loadTransactions()
        {

            if (var == false)
                TransactionInfo.DataSource = transactionDao.GetTransactions().Tables[0];
            else
                
                TransactionInfo.DataSource = transactionDao.SearchTransactions(str).Tables[0];

            var = false;

        }


        private void createTransaction()
        {
            try
            {
                string date = MonthYearBox.Text;
                float revenue = Convert.ToInt32(RevenueBox.Text);
                float expense = Convert.ToInt32(ExpenseBox.Text);
                float profit = Convert.ToInt32(revenue - expense);

                transactionDao.CreateTransaction(new DTO_Class.TransactionDTO(date, revenue, expense, profit));

                loadTransactions();
                ProfitBox.Text = profit.ToString();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Invalid Input!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void updateTransaction()
        {
            string date = MonthYearBox.Text;
            float revenue = Convert.ToInt32(RevenueBox.Text);
            float expense = Convert.ToInt32(ExpenseBox.Text);
            float profit = Convert.ToInt32(revenue - expense);

            transactionDao.UpdateTransaction(new DTO_Class.TransactionDTO(date, revenue, expense, profit));

            loadTransactions();
            ProfitBox.Text = profit.ToString();
        }

        private void deleteTransaction()
        {
            transactionDao.DeleteTransaction(MonthYearBox.Text);

            loadTransactions();
        }

       



        private void TransactionInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (TransactionInfo.SelectedRows.Count == 1)
            {
                int idx = TransactionInfo.SelectedRows[0].Index;

                MonthYearBox.Text = TransactionInfo.Rows[idx].Cells[0].Value.ToString();
                RevenueBox.Text = TransactionInfo.Rows[idx].Cells[1].Value.ToString();
                ExpenseBox.Text = TransactionInfo.Rows[idx].Cells[2].Value.ToString();
                ProfitBox.Text = TransactionInfo.Rows[idx].Cells[3].Value.ToString();


            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {

            string str = "Data Source=.\\sqlexpress;Data Source=DESKTOP-EVASEB4;Initial Catalog=PharmacyManagementSystem;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from trans where MonthYear ='" + MonthYearBox.Text + "'", conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("This month already exist!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                createTransaction();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            OwnerIF f3 = new OwnerIF();
            this.Hide();
            f3.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            deleteTransaction();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            updateTransaction();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            MonthYearBox.Text = String.Empty;
            RevenueBox.Text = String.Empty;
            ExpenseBox.Text = String.Empty;
            ProfitBox.Text = String.Empty;
            SearchBox.Text = String.Empty;

            var = false;
            loadTransactions();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var = true;
            str = SearchBox.Text;
            loadTransactions();
        }

        private void TransactionInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MonthYearBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
