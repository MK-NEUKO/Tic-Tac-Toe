using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using TicTacToe.Model;

namespace TicTacToe.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private PlayerData _playerX;

        public PlayerData PlayerX
        {
            get { return _playerX; }
            set { _playerX = value; }
        }

        private PlayerData _playerO;

        public PlayerData PlayerO
        {
            get { return _playerO; }
            set { _playerO = value; }
        }

        private string[] _gameBoard;

        public string[] GameBoard
        {
            get { return _gameBoard; }
            set { _gameBoard = value; }
        }



        public ICommand EnterNamePlayerXCommand { get; set; }
        public ICommand EnterNamePlayerOCommand { get; set; }
        public ICommand ResetPointsCommand { get; set; }
        public ICommand ChangePlayer { get; set; }
        public ICommand PlaceATileCommand { get; set; }



        public MainViewModel()
        {
            PlayerX = new PlayerData { /*Name = "",*/ Points = 12, InAction = true };
            PlayerO = new PlayerData { /*Name = "",*/ Points = 4, InAction = false };
            GameBoard = new string[9] { "X", "X", "O", "O", "X", "X", "X", "O", "O" };
            

            EnterNamePlayerXCommand = new RelayCommand(EnterNamePlayerXExecute, EnterNamePlayerXCanExecute);
            EnterNamePlayerOCommand = new RelayCommand(EnterNamePlayerOExecute, EnterNamePlayerOCanExecute);
            ResetPointsCommand = new RelayCommand(ResetPointsExecute, ResetPointsCanExecute);
            PlaceATileCommand = new RelayCommand(PlaceATileExecute, PlaceATileCanExecute);
            ChangePlayer = new RelayCommand(ChangePlayerExecute, ChangePlayerCanExecute);

        }

        private bool PlaceATileCanExecute(object obj)
        {
            return true;
        }

        private void PlaceATileExecute(object obj)
        {
            if (obj is Button gameBoardTile)
            {
                gameBoardTile.Content = "OK";
            }
        }

        private void PlayGame()
        {

        }


        private bool ChangePlayerCanExecute(object obj)
        {
            return true;
        }

        private void ChangePlayerExecute(object obj)
        {
            if (PlayerX.InAction)
            {
                PlayerO.InAction = true;
                PlayerX.InAction = false;
            }
            else
            {
                PlayerX.InAction = true;
                PlayerO.InAction = false;
            }
        }

        private bool ResetPointsCanExecute(object obj)
        {
            return true;
        }

        private void ResetPointsExecute(object obj)
        {
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
