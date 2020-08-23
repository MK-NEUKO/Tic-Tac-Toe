using System;
using System.Collections.Generic;
using System.Printing;
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

        private GameData _gameBoard;

        public GameData GameBoard
        {
            get { return _gameBoard; }
            set { _gameBoard = value; }
        }



        public ICommand EnterNamePlayerXCommand { get; set; }
        public ICommand EnterNamePlayerOCommand { get; set; }
        public ICommand ResetPointsCommand { get; set; }
        public ICommand PlaceASigneCommand { get; set; }



        public MainViewModel()
        {
            PlayerX = new PlayerData { /*Name = "",*/ Points = 12, InAction = true };
            PlayerO = new PlayerData { /*Name = "",*/ Points = 4, InAction = false };
            GameBoard = new GameData();
            GameBoard.Array = new string[9];
            GameBoard.Array[1] = "X";


            EnterNamePlayerXCommand = new RelayCommand(EnterNamePlayerXExecute, EnterNamePlayerXCanExecute);
            EnterNamePlayerOCommand = new RelayCommand(EnterNamePlayerOExecute, EnterNamePlayerOCanExecute);
            ResetPointsCommand = new RelayCommand(ResetPointsExecute, ResetPointsCanExecute);
            PlaceASigneCommand = new RelayCommand(PlaceASigneExecute, PlaceASigneCanExecute);
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
            if(obj is Button value)
            {
                if (PlayerX.InAction)
                {
                    GameBoard.Array[0] = "X";
                    //value.Content = "X";
                    PlayerO.InAction = true;
                    PlayerX.InAction = false;
                }
                else
                {
                    value.Content = "O";
                    PlayerO.InAction = false;
                    PlayerX.InAction = true;
                }
            }
        }

        private void PlayGame()
        {

        }


        private bool ResetPointsCanExecute(object obj)
        {
            return true;
        }

        private void ResetPointsExecute(object obj)
        {
            PlayerX.Points = 0;
            PlayerO.Points = 0;
            Array.Clear(GameBoard.Array, 0, 9);
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
