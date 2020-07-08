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

        #region SpielfeldLeeren
        // Was ist besser, SpielfeldLeeren() als Einzelanweisungen,
        // oder eine Schleife

        //public void SpielfeldLeeren()
        //{
        //    feld_0_0.Content = null;
        //    feld_0_1.Content = null;
        //    feld_0_2.Content = null;
        //    feld_1_0.Content = null;
        //    feld_1_1.Content = null;
        //    feld_1_2.Content = null;
        //    feld_2_0.Content = null;
        //    feld_2_1.Content = null;
        //    feld_2_2.Content = null;
        //}

        public void SpielfeldLeeren()
        {
            foreach (UIElement item in spielfeld.Children)
            {
                if (item is Button feld)
                {
                    feld.Content = null;
                    feld.Background = Brushes.DimGray;
                    feld.Foreground = Brushes.LawnGreen;
                    labelHinweise.Visibility = Visibility.Hidden;
                }
            }
        }
        #endregion



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

        private void GewinnerErmitteln()
        {
            // Spielfeld auslesen und in einem String abspeichern
            string spielfeldInhalt = null;
            foreach (UIElement item in spielfeld.Children)
            {
                if (item is Button feld)
                {
                    if (feld.Content == null)
                    {
                        spielfeldInhalt += " ";
                    }
                    else
                    {
                        spielfeldInhalt += feld.Content as string;
                    }                       
                }
            }

            // Es gibt 8 verschiedene Gewinnkonstellationen, der String wird
            // zur Überprüfung für alle 8 Konstellationen zurechtgeschnitten.
            // Zusätzlich wird das Array feldEinfaerben entsprechend initialisiert,
            // um in der Funtion GewinnfelderFaerben() die entsprechenden Felder gelb zu färben.
            
            for (int fall = 1; fall < 9; fall++)
            {
                string gewonnen = null;
                int[] feldEinfaerben = new int[9];
                switch (fall)
                {
                    case 1:
                        gewonnen += spielfeldInhalt[0];
                        gewonnen += spielfeldInhalt[1];
                        gewonnen += spielfeldInhalt[2];
                        feldEinfaerben[0] = 1;
                        feldEinfaerben[1] = 1;
                        feldEinfaerben[2] = 1;
                        break;
                    case 2:
                        gewonnen += spielfeldInhalt[3];
                        gewonnen += spielfeldInhalt[4];
                        gewonnen += spielfeldInhalt[5];
                        feldEinfaerben[3] = 1;
                        feldEinfaerben[4] = 1;
                        feldEinfaerben[5] = 1;
                        break;
                    case 3:
                        gewonnen += spielfeldInhalt[6];
                        gewonnen += spielfeldInhalt[7];
                        gewonnen += spielfeldInhalt[8];
                        feldEinfaerben[6] = 1;
                        feldEinfaerben[7] = 1;
                        feldEinfaerben[8] = 1;
                        break;
                    case 4:
                        gewonnen += spielfeldInhalt[0];
                        gewonnen += spielfeldInhalt[3];
                        gewonnen += spielfeldInhalt[6];
                        feldEinfaerben[0] = 1;
                        feldEinfaerben[3] = 1;
                        feldEinfaerben[6] = 1;
                        break;
                    case 5:
                        gewonnen += spielfeldInhalt[1];
                        gewonnen += spielfeldInhalt[4];
                        gewonnen += spielfeldInhalt[7];
                        feldEinfaerben[1] = 1;
                        feldEinfaerben[4] = 1;
                        feldEinfaerben[7] = 1;
                        break;
                    case 6:
                        gewonnen += spielfeldInhalt[2];
                        gewonnen += spielfeldInhalt[5];
                        gewonnen += spielfeldInhalt[8];
                        feldEinfaerben[2] = 1;
                        feldEinfaerben[5] = 1;
                        feldEinfaerben[8] = 1;
                        break;
                    case 7:
                        gewonnen += spielfeldInhalt[0];
                        gewonnen += spielfeldInhalt[4];
                        gewonnen += spielfeldInhalt[8];
                        feldEinfaerben[0] = 1;
                        feldEinfaerben[4] = 1;
                        feldEinfaerben[8] = 1;
                        break;
                    case 8:
                        gewonnen += spielfeldInhalt[2];
                        gewonnen += spielfeldInhalt[4];
                        gewonnen += spielfeldInhalt[6];
                        feldEinfaerben[2] = 1;
                        feldEinfaerben[4] = 1;
                        feldEinfaerben[6] = 1;
                        break;
                    default:
                        break;
                }

                // Der zurechtgeschnittene String wird geprüft
                if (gewonnen == "XXX")
                {
                    GewinnfelderFaerben(feldEinfaerben);
                    labelHinweise.Visibility = Visibility.Visible;
                    labelHinweise.Content = "Spieler X hat gewonnen";
                    labelHinweise.Background = Brushes.Gray;
                    // MessageBox.Show("Spieler X hat gewonnen");
                    //SpielfeldLeeren();
                }
                else if (gewonnen == "OOO")
                {
                    GewinnfelderFaerben(feldEinfaerben);
                    MessageBox.Show("Spieler O hat gewonnen");
                    SpielfeldLeeren();
                }

            }

        }

        private void GewinnfelderFaerben(int[] array)
        {
            int index = 0;
            foreach (UIElement item in spielfeld.Children)
            {
                if (item is Button feld)
                {
                    //Button feld = item as Button;
                    if (array[index] == 1)
                    {
                        feld.Background = Brushes.Yellow;
                    }
                    index++;
                }
                
            }
        }

        private void Feld_Click(object sender, RoutedEventArgs e)
        {
            Button feld = sender as Button;

            if (istSpielerEins && feld.Content == null)
            {
                feld.Content = "X";
                GewinnerErmitteln();
                istSpielerEins = false;
                istSpielerZwei = true;
            }
            else if (istSpielerZwei && feld.Content == null)
            {
                feld.Content = "O";
                feld.Background = Brushes.LawnGreen;
                feld.Foreground = Brushes.DimGray;
                GewinnerErmitteln();
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
