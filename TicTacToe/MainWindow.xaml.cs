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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Feld_0_0_Click(object sender, RoutedEventArgs e)
        {

            switch (feld_0_0.Content)
            {
                case null:
                    feld_0_0.Content = "X";
                    break;
                case "X":
                    feld_0_0.Content = "O";
                    break;
                case "O":
                    feld_0_0.Content = "X";
                    break;
                default:
                    break;
            }
        }
    }
}
