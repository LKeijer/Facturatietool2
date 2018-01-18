using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Offerte_en_Facturatie_UI
{
    public class Klant
    {


        public void InsertKlant()
        {
            MainWindow main = new MainWindow(); // deze moet weg
            string bedrijfNaam = main.BedrijfNaam;
            string kvkNummer = main.KvK;
            string btwNummer = main.BTW;
            string voorNaam = main.Voornaam;
            string achterNaam = main.Achternaam;
            string straatNaam = main.Straatnaam;
            string huisNummer = main.Huisnummer;
            string postcode = main.Postcode;
            string plaats = main.Plaats;
            string telefoon = main.Telefoon;
            string email = main.Email;
            string website = main.Website;

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(connectionString);
            SqlDataAdapter command = new SqlDataAdapter();

            command.InsertCommand = new SqlCommand("INSERT INTO Bedrijf (Bedrijfsnaam, Email, Website, KvKnummer, BTWnummer) VALUES (@bedrijfNaam, @email, @website, @kvknummer,@btwnummer)", myConnection);
            command.InsertCommand.Parameters.Add("@bedrijfNaam", SqlDbType.VarChar).Value = bedrijfNaam;
            command.InsertCommand.Parameters.Add("@kvknummer", SqlDbType.VarChar).Value = kvkNummer;//
            command.InsertCommand.Parameters.Add("@btwnummer", SqlDbType.VarChar).Value = btwNummer;//
            command.InsertCommand.Parameters.Add("@website", SqlDbType.VarChar).Value = website;//
            command.InsertCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = email;//

            try //inserts data into bedrijf table
            {
                myConnection.Open();
                command.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("inserted into bedrijf " + bedrijfNaam + email + website + kvkNummer + btwNummer);
            }
            finally
            {
                myConnection.Close();
            }

            command.InsertCommand = new SqlCommand("INSERT INTO Particulier (Email, Telefoonnummer) VALUES (@email, @telnummer)", myConnection);
            command.InsertCommand.Parameters.Add("@telnummer", SqlDbType.VarChar).Value = telefoon;//
            command.InsertCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = email;//

            try // inserts data into particulier table
            {
                myConnection.Open();
                command.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("inserted into particulier" + email + telefoon);
            }
            finally
            {
                myConnection.Close();
            }
            command.InsertCommand = new SqlCommand("INSERT INTO Persoon (Voornaam, Achternaam) VALUES (@voornaam, @achternaam)", myConnection);
            command.InsertCommand.Parameters.Add("@voornaam", SqlDbType.VarChar).Value = voorNaam;
            command.InsertCommand.Parameters.Add("@achternaam", SqlDbType.VarChar).Value = achterNaam;
            try // inserts data into table persoon.
            {
                myConnection.Open();
                command.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("inserted into Persoon " + voorNaam + achterNaam);
            }
            finally
            {
                myConnection.Close();
            }

            command.InsertCommand = new SqlCommand("INSERT INTO Adres (Straatnaam, Huisnummer, Postcode, Plaatsnaam) VALUES (@straatnaam, @huisnummer, @postcode, @plaats)", myConnection);
            command.InsertCommand.Parameters.Add("@straatnaam", SqlDbType.VarChar).Value = straatNaam;
            command.InsertCommand.Parameters.Add("@huisnummer", SqlDbType.VarChar).Value = huisNummer;
            command.InsertCommand.Parameters.Add("@postcode", SqlDbType.VarChar).Value = postcode;
            command.InsertCommand.Parameters.Add("@plaats", SqlDbType.VarChar).Value = plaats;
            try
            {
                myConnection.Open();
                command.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("inserted into Adres " + straatNaam + huisNummer + postcode + plaats);
            }
            finally
            {
                myConnection.Close();
            }

        }

    }
}
