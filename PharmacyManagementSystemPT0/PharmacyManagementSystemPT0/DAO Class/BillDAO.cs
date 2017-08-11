using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PharmacyManagementSystemPT0.DAO_Class
{
    class BillDAO
    {
        public string connectionString = "Data Source=.\\sqlexpress;Data Source=DESKTOP-EVASEB4;Initial Catalog=PharmacyManagementSystem;Integrated Security=True";

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand, sqlCommand1, sqlCommand2, sqlCommand3, sqlCommand4;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataSet;


        public BillDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public DataSet GetBills()
        {
            sqlConnection.Open();

            string sqlQuery = "select * from Bill";

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();

            return dataSet;

        }

        public DataSet SearchBills(string str)
        {
            sqlConnection.Open();

            string str1 = "'%" + str + "%'";

            string sqlQuery = "select * from Bill where BillID LIKE " + str1;

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();

            return dataSet;

        }

    }
}
