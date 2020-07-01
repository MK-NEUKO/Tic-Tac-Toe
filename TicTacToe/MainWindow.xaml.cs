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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int zaehler = 1;
        private bool spielerEins = true;
        private bool spielerZwei = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SpielerPruefen()
        {
            if (zaehler % 2 != 0)
            {
                spielerEins = true;
                spielerZwei = false;
            }
            else
            {
                spielerZwei = true;
                spielerEins = false;
            }
            zaehler++;
        }


        private void Feld_Click(object sender, RoutedEventArgs e)
        {
            Button feld = (Button)sender;
            SpielerPruefen();

            if (spielerEins && feld.Content == null)
            {
                feld.Content = "X";
            }
            else if (spielerZwei && feld.Content == null)
            {
                feld.Content = "O";
            }
            //else if ((spielerEins || spielerZwei) && feld.Content != null)
            //{

            //}
        }
    }
}
