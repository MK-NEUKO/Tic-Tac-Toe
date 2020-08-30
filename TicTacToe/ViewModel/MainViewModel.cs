using System.Printing;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace TicTacToe.ViewModel
{
    partial class MainViewModel : ViewModelBase
    {
        public PlayerData PlayerX { get; set; }
        public PlayerData PlayerO { get; set; }
        public Winner Board { get; set; }


        public ICommand EnterNamePlayerXCommand { get; set; }
        public ICommand EnterNamePlayerOCommand { get; set; }
        public ICommand ResetPointsCommand { get; set; }
        public ICommand PlaceASigneCommand { get; set; }



        public MainViewModel()
        {
            PlayerX = new PlayerData { /*Name = "",*/ Points = 12, InAction = true };
            PlayerO = new PlayerData { /*Name = "",*/ Points = 4, InAction = false };
            Board = new Winner();
           
            EnterNamePlayerXCommand = new RelayCommand(EnterNamePlayerXExecute, EnterNamePlayerXCanExecute);
            EnterNamePlayerOCommand = new RelayCommand(EnterNamePlayerOExecute, EnterNamePlayerOCanExecute);
            ResetPointsCommand = new RelayCommand(ResetPointsExecute, ResetPointsCanExecute);
            PlaceASigneCommand = new RelayCommand(PlaceASigneExecute, PlaceASigneCanExecute);
        }

        private void PlayTicTacToe(string name, string signe)
        {
            bool winnerX = false;
            bool winnerO = false;
            
            Board.PlaceASigne(name, signe);
            winnerX = Board.CheckForWinnerX();
            winnerO = Board.CheckForWinnerO();
            if (winnerX)
                PlayerX.Points++;
            if (winnerO)
                PlayerO.Points++;            
        }


        private bool PlaceASigneCanExecute(object obj)
        {
            if (obj is Button)
                return true;
            else
                // Fehlermeldung
                return false;
        }

        private void PlaceASigneExecute(object obj)
        {
            if (obj is Button value)
            {
                if (PlayerX.InAction)
                {
                    PlayTicTacToe(value.Name, "X");
                    PlayerO.InAction = true;
                    PlayerX.InAction = false;
                }
                else
                {
                    PlayTicTacToe(value.Name, "O");
                    PlayerO.InAction = false;
                    PlayerX.InAction = true;
                }
            }
        }


        private bool ResetPointsCanExecute(object obj)
        {
            return true;
        }

        private void ResetPointsExecute(object obj)
        {
            Board.ClearGameBoard();
            PlayerX.Points = 0;
            PlayerO.Points = 0;
        }

        private bool EnterNamePlayerOCanExecute(object obj)
        {
            if (obj != null)
            {
                TextBox textBox = obj as TextBox;
                return textBox.Text != "";
            }
            return false;
        }

        private void EnterNamePlayerOExecute(object obj)
        {
            TextBox textBox = obj as TextBox;
            PlayerO.Name = textBox.Text;
        }

        private bool EnterNamePlayerXCanExecute(object obj)
        {
            if (obj != null)
            {
                TextBox textBox = obj as TextBox;
                return textBox.Text != "";
            }
            return false;
        }

        private void EnterNamePlayerXExecute(object obj)
        {
            TextBox textBox = obj as TextBox;
            PlayerX.Name = textBox.Text;
        }
    }
}
