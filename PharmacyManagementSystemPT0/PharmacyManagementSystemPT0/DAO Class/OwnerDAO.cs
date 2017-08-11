using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PharmacyManagementSystemPT0
{
    class OwnerDAO
    {
        public string connectionString = "Data Source=.\\sqlexpress;Data Source=DESKTOP-EVASEB4;Initial Catalog=PharmacyManagementSystem;Integrated Security=True";

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand, sqlCommand1, sqlCommand2;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataSet;

        public OwnerDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public DataSet GetOwners()
        {
            sqlConnection.Open();

            string sqlQuery = "select * from Owner";

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();

            return dataSet;

        }

        public void CreateOwner(OwnerDTO ownerDTO)
        {

            sqlConnection.Open();
            string sqlQuery = " insert into Owner values('" + ownerDTO.OwnerID +
                                                           "','" + ownerDTO.OwnerNAME +
                                                           "','" + ownerDTO.OwnerPASSWORD +
                                                            "')";

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();


        }

        public void DeleteOwner(int id)
        {
            sqlConnection.Open();

            string sqlQuery = " delete from Owner where OwnerID=" + id;

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

        }

        public void UpdateOwner(OwnerDTO ownerDTO)
        {
            sqlConnection.Open();

            string sqlQuery = "Update Owner SET OwnerID='" + ownerDTO.OwnerID + "' where OwnerID='" + ownerDTO.OwnerID + "'";

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            string sqlQuery1 = "Update Owner SET OwnerName='" + ownerDTO.OwnerNAME + "' where OwnerID='" + ownerDTO.OwnerID + "'";

            sqlCommand1 = new SqlCommand(sqlQuery1, sqlConnection);
            sqlCommand1.ExecuteNonQuery(); 

            string sqlQuery2 = "Update Owner SET Password='" + ownerDTO.OwnerPASSWORD + "' where OwnerID='" + ownerDTO.OwnerID + "'";

            sqlCommand2 = new SqlCommand(sqlQuery2, sqlConnection);
            sqlCommand2.ExecuteNonQuery();

            

            sqlConnection.Close();

        }


        public DataSet SearchOwners(string str)
        {
            sqlConnection.Open();

            string str1 = "'%" + str + "%'";

            string sqlQuery = "select * from Owner where OwnerName LIKE " + str1;

            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();

            return dataSet;

        }
    }


}
