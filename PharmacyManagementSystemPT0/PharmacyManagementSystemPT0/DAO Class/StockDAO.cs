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
    class StockDAO
    {
        public string connectionString = "Data Source=.\\sqlexpress;Data Source=DESKTOP-EVASEB4;Initial Catalog=PharmacyManagementSystem;Integrated Security=True";

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand, sqlCommand1, sqlCommand2, sqlCommand3, sqlCommand4;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataSet;


        public StockDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public DataSet GetStocks()
        {
            sqlConnection.Open();

            string sqlQuery = "select * from Stock";

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();

            return dataSet;

        }

        public DataSet GetStockByOrder()
        {
            sqlConnection.Open();

            string sqlQuery = "select * from Stock order by MedicineName";

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();

            return dataSet;

        }
        public void CreateStock(DTO_Class.StockDTO stockDTO)
        {
            try
            {
                sqlConnection.Open();
                string sqlQuery = " insert into Stock values('" + stockDTO.MedicineID +
                                                               "','" + stockDTO.MedicineNAME +
                                                               "','" + stockDTO.PRICE +
                                                               "','" + stockDTO.QUANTITY +
                                                               "','" + stockDTO.MedicineTYPE +
                                                                "')";

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Input!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void DeleteStock(int id)
        {
            sqlConnection.Open();

            string sqlQuery = " delete from Stock where MedicineID=" + id;

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

        }
        public void UpdateStock(DTO_Class.StockDTO stockDTO)
        {
            sqlConnection.Open();

       /*     string sqlQuery = "Update Owner SET OwnerID='" + ownerDTO.OwnerID + "' where OwnerID='" + ownerDTO.OwnerID + "'";

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();

      */

            string sqlQuery1 = "Update Stock SET MedicineName='" + stockDTO.MedicineNAME + "' where MedicineID='" + stockDTO.MedicineID + "'";

            sqlCommand1 = new SqlCommand(sqlQuery1, sqlConnection);
            sqlCommand1.ExecuteNonQuery();

            string sqlQuery2 = "Update Stock SET Price='" + stockDTO.PRICE + "' where MedicineID='" + stockDTO.MedicineID + "'";

            sqlCommand2 = new SqlCommand(sqlQuery2, sqlConnection);
            sqlCommand2.ExecuteNonQuery();


            string sqlQuery3 = "Update Stock SET Quantity='" + stockDTO.QUANTITY + "' where MedicineID='" + stockDTO.MedicineID + "'";

            sqlCommand3 = new SqlCommand(sqlQuery3, sqlConnection);
            sqlCommand3.ExecuteNonQuery();

            string sqlQuery4 = "Update Stock SET MedicineType='" + stockDTO.MedicineTYPE + "' where MedicineID='" + stockDTO.MedicineID + "'";

            sqlCommand4 = new SqlCommand(sqlQuery4, sqlConnection);
            sqlCommand4.ExecuteNonQuery();


            sqlConnection.Close();

        }



        public DataSet SearchStocks(string str)
        {
            sqlConnection.Open();

            string str1 = "'%" + str + "%'";

            string sqlQuery = "select * from Stock where MedicineName LIKE " + str1;

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();

            return dataSet;

        }









    }
}
