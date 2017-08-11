using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PharmacyManagementSystemPT0.DAO_Class
{
    class TransactionDAO
    {
        public string connectionString = "Data Source=.\\sqlexpress;Data Source=DESKTOP-EVASEB4;Initial Catalog=PharmacyManagementSystem;Integrated Security=True";

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand, sqlCommand1, sqlCommand2, sqlCommand3;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataSet;



        public TransactionDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }



        public DataSet GetTransactions()
        {
            sqlConnection.Open();

            string sqlQuery = "select * from trans";

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();

            return dataSet;

        }

        public void CreateTransaction(DTO_Class.TransactionDTO transactionDTO)
        {

            try
            {
                sqlConnection.Open();
                string sqlQuery = " insert into trans values('" + transactionDTO.DATE +
                                                               "','" + transactionDTO.REVENUE +
                                                               "','" + transactionDTO.EXPENSE +
                                                               "','" + transactionDTO.PROFIT +
                                                                "')";

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch( Exception ex)
            {
                MessageBox.Show("Invalid Input!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        public void DeleteTransaction( string date )
        {
            sqlConnection.Open();

            string sqlQuery = "delete from trans where MonthYear = '" + date + "'";

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }



        public void UpdateTransaction(DTO_Class.TransactionDTO transactionDTO)
        {

            sqlConnection.Open();

            string sqlQuery = "Update trans SET MonthYear='" + transactionDTO.DATE + "' where MonthYear='" + transactionDTO.DATE + "'";

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            string sqlQuery1 = "Update trans SET Revenue='" + transactionDTO.REVENUE + "' where MonthYear='" + transactionDTO.DATE + "'";

            sqlCommand1 = new SqlCommand(sqlQuery1, sqlConnection);
            sqlCommand1.ExecuteNonQuery();

            string sqlQuery2 = "Update trans SET Expense='" + transactionDTO.EXPENSE + "' where MonthYear='" + transactionDTO.DATE + "'";

            sqlCommand2 = new SqlCommand(sqlQuery2, sqlConnection);
            sqlCommand2.ExecuteNonQuery();


            string sqlQuery3 = "Update trans SET Profit='" + transactionDTO.PROFIT + "' where MonthYear='" + transactionDTO.DATE + "'";

            sqlCommand3 = new SqlCommand(sqlQuery3, sqlConnection);
            sqlCommand3.ExecuteNonQuery();

            sqlConnection.Close();

        }






        public DataSet SearchTransactions(string str)
        {
            sqlConnection.Open();

            string str1 = "'%" + str + "%'";

            string sqlQuery = "select * from trans where MonthYear LIKE " + str1;

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();

            return dataSet;

        }





    }
}
