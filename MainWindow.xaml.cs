using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Offerte_en_Facturatie_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow(string bedrijf)
        {
            bedrijfInput = bedrijf;
        }

        string bedrijfInput;
        string kvkInput;
        string btwNummer;
        string voornaam;
        string achternaam;
        string straatnaam;
        string huisnummer;
        string postcode;
        string plaats;
        string telefoonnummer;
        string email;
        string website;

        Klant klant = new Klant();

        public MainWindow()
        {
            InitializeComponent();

        }

        public void SetTextBoxes()
        {
            bedrijfInput = Form1_Bedrijfsnaam.Text;
            kvkInput = Form1_KvKNummer.Text;
            btwNummer = Form1_BTWNummer.Text;
            voornaam = Form1_ContactVoornaam.Text;
            achternaam = Form1_Achternaam.Text;
            huisnummer = Form1_Huisnummer.Text;
            postcode = Form1_Postcode.Text;
            plaats = Form1_Plaats.Text;
            telefoonnummer = Form1_TelNummer.Text;
            email = Form1_EMail.Text;
            website = Form1_Website.Text;
        }

        #region WPF Controls

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }


        private void BtnNieuweKlant_Click(object sender, RoutedEventArgs e)
        {
            klanttabControl.SelectedItem = tab_NieuweKlant;
        }

        private void BtnKlantBekijken_Click(object sender, RoutedEventArgs e)
        {
            klanttabControl.SelectedItem = tab_KlantBekijken;
        }

        private void BtnKlantAanpassen_Click(object sender, RoutedEventArgs e)
        {
            klanttabControl.SelectedItem = tab_KlantAanpassen;
        }


        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        private void BtnNieuweOfferte_Click(object sender, RoutedEventArgs e)
        {
            offertetabControl.SelectedItem = tab_NieuweOfferte;
        }

        private void BtnOfferteBekijken_Click(object sender, RoutedEventArgs e)
        {
            offertetabControl.SelectedItem = tab_OfferteBekijken;
        }


        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        private void BtnNieuweFactuur_Click(object sender, RoutedEventArgs e)
        {
            factuurtabControl.SelectedItem = tab_NieuweFactuur;
        }

        private void BtnFactuurBekijken_Click(object sender, RoutedEventArgs e)
        {
            factuurtabControl.SelectedItem = tab_FactuurBekijken;
        }
        #endregion

        #region GET/SET TEXTBOX STRINGS
        public string BedrijfNaam
        {
            get { return bedrijfInput; }
            set { bedrijfInput = value; }
        }
        public string KvK
        {
            get { return kvkInput; }
            set { kvkInput = value; }
        }
        public string BTW
        {
            get { return btwNummer; }
            set { btwNummer = value; }
        }

        public string Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; }
        }

        public string Achternaam
        {
            get { return achternaam; }
            set { achternaam = value;}
        }

        public string Straatnaam
        {
            get { return straatnaam; }
            set { straatnaam = value; }
        }

        public string Huisnummer
        {
            get { return huisnummer; }
            set { huisnummer = value; }
        }

        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        public string Plaats
        {
            get { return plaats; }
            set { plaats = value; }
        }

        public string Telefoon
        {
            get { return telefoonnummer; }
            set { telefoonnummer = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Website
        {
            get { return website; }
            set { website = value; }
        }
#endregion

        private void Form1_btnAccepteer_Click(object sender, RoutedEventArgs e)
        {
            SetTextBoxes();
            klant.InsertKlant();
        }
    }
}
