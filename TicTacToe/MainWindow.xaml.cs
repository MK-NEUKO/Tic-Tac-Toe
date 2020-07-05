using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool istSpielerEins = true;
        private bool istSpielerZwei = false;
        public MainWindow()
        {
            InitializeComponent();
            SpielfeldLeeren();
        }

        public void SpielfeldLeeren()
        {
            feld_0_0.Content = null;
            feld_0_1.Content = null;
            feld_0_2.Content = null;
            feld_1_0.Content = null;
            feld_1_1.Content = null;
            feld_1_2.Content = null;
            feld_2_0.Content = null;
            feld_2_1.Content = null;
            feld_2_2.Content = null;
        }

        private bool IstSpielfeldVoll()
        {
            foreach (UIElement stein in spielfeld.Children)
            {
                if (stein is Button feld)
                {
                    if (feld.Content == null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        private void Feld_Click(object sender, RoutedEventArgs e)
        {
            Button feld = (Button)sender;

            if (istSpielerEins && feld.Content == null)
            {
                feld.Content = "X";
                istSpielerEins = false;
                istSpielerZwei = true;
            }
            else if (istSpielerZwei && feld.Content == null)
            {
                feld.Content = "O";
                istSpielerZwei = false;
                istSpielerEins = true;
            }
            else if (feld.Content != null)
            {
                MessageBox.Show("Dieses Kästchen ist bereits belegt! Wähle ein anderes.", "Unzulässiger Zug");
   
                if (IstSpielfeldVoll())
                {
                    SpielfeldLeeren();
                    istSpielerEins = true;
                    istSpielerZwei = false;
                }
            }
            
        }

    }
}
