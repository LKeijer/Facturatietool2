using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Offerte_en_Facturatie_UI
{
    class Connection
    {

        SqlConnection myConnection = new SqlConnection();
        SqlDataAdapter command = new SqlDataAdapter();
        MainWindow main = new MainWindow();



       /* public void InsertBedrijfsNaam()
        {
            MainWindow main = new MainWindow();
            string bedrijfInput = main.Form1_Bedrijfsnaam.Text;
            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(connectionString);
            command.InsertCommand = new SqlCommand("INSERT INTO Bedrijf (Bedrijfsnaam) VALUES (@bedrijfNaam)", myConnection);
            command.InsertCommand.Parameters.Add("@bedrijfNaam", SqlDbType.VarChar).Value = bedrijfInput;
            try
            {
                myConnection.Open();
                command.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted "+ bedrijfInput);
            }
            finally
            {
                myConnection.Close();
            }

        }*/

        public void InsertKlant()
        {

        }


    }
}
