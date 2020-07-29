using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Threading;
using TicTacToe.Model;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player playerXX = new Player { Name = "Michael", Points = 5, ReadyToPlay = true };
        //PlayerData playerOO = new PlayerData { Name = "Hans", Points = 7, ReadyToPlay = false };
        //private bool gewinnerX = false;
        //private bool gewinnerO = false;
        //private int punkteX = 0;
        //private int punkteO = 0;
        //private bool istSpielerEins = true;
        //private readonly DispatcherTimer _animationTimer = new DispatcherTimer();
        //private bool animation = false;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = playerXX;
            //SpielfeldLeeren();

            //_animationTimer.Tick += new EventHandler(LabelAusblenden);
            //_animationTimer.Interval = TimeSpan.FromSeconds(4);

        }

    //    private void Feld_Click(object sender, RoutedEventArgs e)
    //    {
    //        Button feld = sender as Button;

    //        if (labelmitteilung.Visibility == Visibility.Visible || animation)
    //        {
    //            labelmitteilung.Visibility = Visibility.Hidden;
    //            labelmitteilung.Content = string.Empty;

    //            if (gewinnerX || gewinnerO || IstSpielfeldVoll())
    //            {
    //                SpielfeldLeeren();
    //            }

    //            animation = false;
    //            return;
    //        }

    //        if (istSpielerEins && feld.Content == null)
    //        {
    //            feld.Content = "X";
    //            GewinnerErmitteln();
    //            istSpielerEins = false;
    //        }
    //        else if (!istSpielerEins && feld.Content == null)
    //        {
    //            feld.Content = "O";
    //            feld.Background = Brushes.LawnGreen;
    //            feld.Foreground = Brushes.DimGray;
    //            GewinnerErmitteln();
    //            istSpielerEins = true;
    //        }
    //        else if (feld.Content != null)
    //        {
    //            MitteilungAnzeigen("Das Feld ist besetzt!");
    //        }
            
    //    }

    //    public void SpielfeldLeeren()
    //    {
    //        foreach (UIElement item in spielfeld.Children)
    //        {
    //            if (item is Button feld)
    //            {
    //                feld.Content = null;
    //                feld.Background = Brushes.DimGray;
    //                feld.Foreground = Brushes.LawnGreen;
    //                labelmitteilung.Visibility = Visibility.Hidden;
    //                labelmitteilung.Content = string.Empty;
    //            }
    //        }
    //        gewinnerX = false;
    //        gewinnerO = false;
    //    }

    //    private bool IstSpielfeldVoll()
    //    {
    //        foreach (UIElement stein in spielfeld.Children)
    //        {
    //            if (stein is Button feld)
    //            {
    //                if (feld.Content == null)
    //                {
    //                    return false;
    //                }
    //            }
    //        }
    //        return true;
    //    }

    //    private bool GewinnerErmitteln()
    //    {
    //        // Spielfeld auslesen und in einem String abspeichern
    //        string spielfeldInhalt = null;

    //        foreach (UIElement item in spielfeld.Children)
    //        {
    //            if (item is Button feld)
    //            {
    //                if (feld.Content == null)
    //                {
    //                    spielfeldInhalt += " ";
    //                }
    //                else
    //                {
    //                    spielfeldInhalt += feld.Content as string;
    //                }
    //            }
    //        }

    //        // Es gibt 8 verschiedene Gewinnkonstellationen, der String wird
    //        // zur Überprüfung für alle 8 Konstellationen zurechtgeschnitten.
    //        // Zusätzlich wird das Array feldEinfaerben entsprechend initialisiert,
    //        // um in der Funtion GewinnfelderFaerben() die entsprechenden Felder gelb zu färben.

    //        for (int fall = 1; fall < 9; fall++)
    //        {
    //            string gewonnen = null;
    //            int[] feldEinfaerben = new int[9];
    //            switch (fall)
    //            {
    //                case 1:
    //                    gewonnen += spielfeldInhalt[0];
    //                    gewonnen += spielfeldInhalt[1];
    //                    gewonnen += spielfeldInhalt[2];
    //                    feldEinfaerben[0] = 1;
    //                    feldEinfaerben[1] = 1;
    //                    feldEinfaerben[2] = 1;
    //                    break;
    //                case 2:
    //                    gewonnen += spielfeldInhalt[3];
    //                    gewonnen += spielfeldInhalt[4];
    //                    gewonnen += spielfeldInhalt[5];
    //                    feldEinfaerben[3] = 1;
    //                    feldEinfaerben[4] = 1;
    //                    feldEinfaerben[5] = 1;
    //                    break;
    //                case 3:
    //                    gewonnen += spielfeldInhalt[6];
    //                    gewonnen += spielfeldInhalt[7];
    //                    gewonnen += spielfeldInhalt[8];
    //                    feldEinfaerben[6] = 1;
    //                    feldEinfaerben[7] = 1;
    //                    feldEinfaerben[8] = 1;
    //                    break;
    //                case 4:
    //                    gewonnen += spielfeldInhalt[0];
    //                    gewonnen += spielfeldInhalt[3];
    //                    gewonnen += spielfeldInhalt[6];
    //                    feldEinfaerben[0] = 1;
    //                    feldEinfaerben[3] = 1;
    //                    feldEinfaerben[6] = 1;
    //                    break;
    //                case 5:
    //                    gewonnen += spielfeldInhalt[1];
    //                    gewonnen += spielfeldInhalt[4];
    //                    gewonnen += spielfeldInhalt[7];
    //                    feldEinfaerben[1] = 1;
    //                    feldEinfaerben[4] = 1;
    //                    feldEinfaerben[7] = 1;
    //                    break;
    //                case 6:
    //                    gewonnen += spielfeldInhalt[2];
    //                    gewonnen += spielfeldInhalt[5];
    //                    gewonnen += spielfeldInhalt[8];
    //                    feldEinfaerben[2] = 1;
    //                    feldEinfaerben[5] = 1;
    //                    feldEinfaerben[8] = 1;
    //                    break;
    //                case 7:
    //                    gewonnen += spielfeldInhalt[0];
    //                    gewonnen += spielfeldInhalt[4];
    //                    gewonnen += spielfeldInhalt[8];
    //                    feldEinfaerben[0] = 1;
    //                    feldEinfaerben[4] = 1;
    //                    feldEinfaerben[8] = 1;
    //                    break;
    //                case 8:
    //                    gewonnen += spielfeldInhalt[2];
    //                    gewonnen += spielfeldInhalt[4];
    //                    gewonnen += spielfeldInhalt[6];
    //                    feldEinfaerben[2] = 1;
    //                    feldEinfaerben[4] = 1;
    //                    feldEinfaerben[6] = 1;
    //                    break;
    //                default:
    //                    break;
    //            }

    //            // Der zurechtgeschnittene String wird geprüft
    //            if (gewonnen == "XXX")
    //            {
    //                GewinnfelderFaerben(feldEinfaerben);
    //                gewinnerX = true;
    //                gewinnerO = false;
    //                GewinnerSpielstandAnzeigen();
    //                break;
    //            }
    //            else if (gewonnen == "OOO")
    //            {
                    
    //                GewinnfelderFaerben(feldEinfaerben);
    //                gewinnerO = true;
    //                gewinnerX = false;
    //                GewinnerSpielstandAnzeigen();
    //                break;
    //            }
    //            else if (IstSpielfeldVoll())
    //            {
    //                MitteilungAnzeigen("Unentschieden!\nX = " + punkteX + " : " + punkteO + " = O");
    //                break;
    //            }

    //        }
    //        return false;
    //    }

    //    private void GewinnfelderFaerben(int[] array)
    //    {
    //        int index = 0;
    //        foreach (UIElement item in spielfeld.Children)
    //        {
    //            if (item is Button feld)
    //            {
    //                if (array[index] == 1)
    //                {
    //                    feld.Background = Brushes.Yellow;
    //                }
    //                index++;
    //            }

    //        }
    //    }

    //    private void LabelAusblenden(object sender, EventArgs e)
    //    {
    //        labelmitteilung.Visibility = Visibility.Hidden;
    //        labelmitteilung.Content = string.Empty;
    //        animation = true;
    //        _animationTimer.Stop();        
    //    }

    //    private void MitteilungAnzeigen(string mitteilung)
    //    {
    //        _animationTimer.Start();
    //        labelmitteilung.Visibility = Visibility.Visible;
    //        labelmitteilung.Content = new TextBlock { Inlines = { mitteilung }, TextAlignment = TextAlignment.Center };
    //    }

    //    private void GewinnerSpielstandAnzeigen()
    //    {
    //        if (gewinnerX)
    //        {
    //            punkteX++;
    //            MitteilungAnzeigen($"Spieler \"X\" hat gewonnen !{Environment.NewLine}X = {punkteX} : {punkteO} = O");
    //        }
    //        else if (gewinnerO)
    //        {
    //            punkteO++;
    //            MitteilungAnzeigen("Spieler \"O\" hat gewonnen !\nX = " + punkteX + " : " + punkteO + " = O");
    //        }
            
    //    }
       
    }
}
