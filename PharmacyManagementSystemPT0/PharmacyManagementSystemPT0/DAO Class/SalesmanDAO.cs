using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PharmacyManagementSystemPT0
{
    class SalesmanDAO
    {
        public string connectionString = "Data Source=.\\sqlexpress;Data Source=DESKTOP-EVASEB4;Initial Catalog=PharmacyManagementSystem;Integrated Security=True";

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand, sqlCommand1, sqlCommand2, sqlCommand3;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataSet;


        public SalesmanDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }


        public DataSet GetSalesmans()
        {
            sqlConnection.Open();

            string sqlQuery = "select * from Salesman";

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();

            return dataSet;

        }



        public void CreateSalesman(SalesmanDTO salesmanDTO)
        {

           try
            {
                sqlConnection.Open();
                string sqlQuery = " insert into Salesman values('" + salesmanDTO.SalesmanID +
                                                               "','" + salesmanDTO.SalesmanNAME +
                                                               "','" + salesmanDTO.SalesmanPASSWORD +
                                                                "','" + salesmanDTO.SalesmanADDRESS +
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

        public void DeleteSalesman( int id )
        {
            sqlConnection.Open();

            string sqlQuery = " delete from Salesman where SalesmanID=" + id;

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }


        public void UpdateSalesman (SalesmanDTO salesmanDTO)
        {

            sqlConnection.Open();

            string sqlQuery = "Update Salesman SET SalesmanID='" + salesmanDTO.SalesmanID + "' where SalesmanID='" + salesmanDTO.SalesmanID + "'";

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            string sqlQuery1 = "Update Salesman SET SalesmanName='" + salesmanDTO.SalesmanNAME + "' where SalesmanID='" + salesmanDTO.SalesmanID + "'";

            sqlCommand1 = new SqlCommand(sqlQuery1, sqlConnection);
            sqlCommand1.ExecuteNonQuery();

            string sqlQuery2 = "Update Salesman SET Password='" + salesmanDTO.SalesmanPASSWORD + "' where SalesmanID='" + salesmanDTO.SalesmanID + "'";

            sqlCommand2 = new SqlCommand(sqlQuery2, sqlConnection);
            sqlCommand2.ExecuteNonQuery();


            string sqlQuery3 = "Update Salesman SET Address='" + salesmanDTO.SalesmanADDRESS + "' where SalesmanID='" + salesmanDTO.SalesmanID + "'";

            sqlCommand3 = new SqlCommand(sqlQuery3, sqlConnection);
            sqlCommand3.ExecuteNonQuery();

            sqlConnection.Close();

        }



        public DataSet SearchSalesmans(string str)
        {
            sqlConnection.Open();

            string str1 = "'%" + str + "%'";

            string sqlQuery = "select * from Salesman where SalesmanName LIKE " + str1;

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();

            return dataSet;

        }

    }
}
