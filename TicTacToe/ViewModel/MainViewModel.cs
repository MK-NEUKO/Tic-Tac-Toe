using System;
using System.Printing;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace TicTacToe.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public PlayerData PlayerX { get; set; }
        public PlayerData PlayerO { get; set; }
        public GameBoard Board { get; set; }


        public ICommand EnterNamePlayerXCommand { get; set; }
        public ICommand EnterNamePlayerOCommand { get; set; }
        public ICommand ResetPointsCommand { get; set; }
        public ICommand BoardArea0Command { get; set; }
        public ICommand BoardArea1Command { get; set; }
        public ICommand BoardArea2Command { get; set; }
        public ICommand BoardArea3Command { get; set; }
        public ICommand BoardArea4Command { get; set; }
        public ICommand BoardArea5Command { get; set; }
        public ICommand BoardArea6Command { get; set; }
        public ICommand BoardArea7Command { get; set; }
        public ICommand BoardArea8Command { get; set; }


        public MainViewModel()
        {
            PlayerX = new PlayerData { /*Name = "",*/ Points = 12, InAction = true };
            PlayerO = new PlayerData { /*Name = "",*/ Points = 4, InAction = false };
            Board = new GameBoard();
           
            EnterNamePlayerXCommand = new RelayCommand(EnterNamePlayerXExecute, EnterNamePlayerXCanExecute);
            EnterNamePlayerOCommand = new RelayCommand(EnterNamePlayerOExecute, EnterNamePlayerOCanExecute);
            ResetPointsCommand = new RelayCommand(ResetPointsExecute, ResetPointsCanExecute);
            BoardArea0Command = new RelayCommand(BoardArea0Execute, BoardArea0CanExecute);
            BoardArea1Command = new RelayCommand(BoardArea1Execute, BoardArea1CanExecute);
            BoardArea2Command = new RelayCommand(BoardArea2Execute, BoardArea2CanExecute);
            BoardArea3Command = new RelayCommand(BoardArea3Execute, BoardArea3CanExecute);
            BoardArea4Command = new RelayCommand(BoardArea4Execute, BoardArea4CanExecute);
            BoardArea5Command = new RelayCommand(BoardArea5Execute, BoardArea5CanExecute);
            BoardArea6Command = new RelayCommand(BoardArea6Execute, BoardArea6CanExecute);
            BoardArea7Command = new RelayCommand(BoardArea7Execute, BoardArea7CanExecute);
            BoardArea8Command = new RelayCommand(BoardArea8Execute, BoardArea8CanExecute);
        }

        private bool BoardArea8CanExecute(object obj)
        {
            if (obj is Button)
                return true;
            else
                // Fehlermeldung
                return false;
        }

        private void BoardArea8Execute(object obj)
        {
            int boardAreaId = 8;
            if (PlayerX.InAction)
                PlayTicTacToe(boardAreaId, "X");
            else if (PlayerO.InAction)
                PlayTicTacToe(boardAreaId, "O");
        }

        private bool BoardArea7CanExecute(object obj)
        {
            if (obj is Button)
                return true;
            else
                // Fehlermeldung
                return false;
        }

        private void BoardArea7Execute(object obj)
        {
            int boardAreaId = 7;
            if (PlayerX.InAction)
                PlayTicTacToe(boardAreaId, "X");
            else if (PlayerO.InAction)
                PlayTicTacToe(boardAreaId, "O");
        }

        private bool BoardArea6CanExecute(object obj)
        {
            if (obj is Button)
                return true;
            else
                // Fehlermeldung
                return false;
        }

        private void BoardArea6Execute(object obj)
        {
            int boardAreaId = 6;
            if (PlayerX.InAction)
                PlayTicTacToe(boardAreaId, "X");
            else if (PlayerO.InAction)
                PlayTicTacToe(boardAreaId, "O");
        }

        private bool BoardArea5CanExecute(object obj)
        {
            if (obj is Button)
                return true;
            else
                // Fehlermeldung
                return false;
        }

        private void BoardArea5Execute(object obj)
        {
            int boardAreaId = 5;
            if (PlayerX.InAction)
                PlayTicTacToe(boardAreaId, "X");
            else if (PlayerO.InAction)
                PlayTicTacToe(boardAreaId, "O");
        }

        private bool BoardArea4CanExecute(object obj)
        {
            if (obj is Button)
                return true;
            else
                // Fehlermeldung
                return false;
        }

        private void BoardArea4Execute(object obj)
        {
            int boardAreaId = 4;
            if (PlayerX.InAction)
                PlayTicTacToe(boardAreaId, "X");
            else if (PlayerO.InAction)
                PlayTicTacToe(boardAreaId, "O");
        }

        private bool BoardArea3CanExecute(object obj)
        {
            if (obj is Button)
                return true;
            else
                // Fehlermeldung
                return false;
        }

        private void BoardArea3Execute(object obj)
        {
            int boardAreaId = 3;
            if (PlayerX.InAction)
                PlayTicTacToe(boardAreaId, "X");
            else if (PlayerO.InAction)
                PlayTicTacToe(boardAreaId, "O");
        }

        private bool BoardArea2CanExecute(object obj)
        {
            if (obj is Button)
                return true;
            else
                // Fehlermeldung
                return false;
        }

        private void BoardArea2Execute(object obj)
        {
            int boardAreaId = 2;
            if (PlayerX.InAction)
                PlayTicTacToe(boardAreaId, "X");
            else if (PlayerO.InAction)
                PlayTicTacToe(boardAreaId, "O");
        }

        private bool BoardArea1CanExecute(object obj)
        {
            if (obj is Button)
                return true;
            else
                // Fehlermeldung
                return false;
        }

        private void BoardArea1Execute(object obj)
        {
            int boardAreaId = 1;
            if (PlayerX.InAction)
                PlayTicTacToe(boardAreaId, "X");
            else if (PlayerO.InAction)
                PlayTicTacToe(boardAreaId, "O");
        }

        private bool BoardArea0CanExecute(object obj)
        {
            if (obj is Button)
                return true;
            else
                // Fehlermeldung
                return false;
        }

        private void BoardArea0Execute(object obj)
        {
            int boardAreaId = 0;
            if (PlayerX.InAction)
                PlayTicTacToe(boardAreaId, "X");
            else if(PlayerO.InAction)
                PlayTicTacToe(boardAreaId, "O");
        }

        private void PlayTicTacToe(int boardAreaId, string signe)
        {
           
            Board.PlaceASigne(boardAreaId, signe);
            if (PlayerX.InAction)
            {
                bool winnerX = Board.CheckForWinnerX();
                if (winnerX)
                    PlayerX.Points++;
                PlayerX.InAction = false;
                PlayerO.InAction = true;
            }
            else if (PlayerO.InAction)
            {
                bool winnerO = Board.CheckForWinnerO();
                if (winnerO)
                    PlayerO.Points++;
                PlayerO.InAction = false;
                PlayerX.InAction = true;
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
