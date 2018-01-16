using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();
          
        }

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

    }
}
