using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace TicTacToe.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private PlayerData _playerX;

        public PlayerData PlayerX
        {
            get { return _playerX; }
            set { SetProperty<PlayerData>(ref _playerX, value); }
        }

        private PlayerData _playerO;

        public PlayerData PlayerO
        {
            get { return _playerO; }
            set { SetProperty<PlayerData>(ref _playerO, value); }
        }

        public ICommand EnterNamePlayerXCommand { get; set; }
        public ICommand EnterNamePlayerOCommand { get; set; }
        public ICommand ResetPointsCommand { get; set; }
        public ICommand ChangePlayer { get; set; }



        public MainViewModel()
        {
            PlayerX = new PlayerData { /*Name = "",*/ Points = 12, InAction = true };
            PlayerO = new PlayerData { /*Name = "",*/ Points = 4, InAction = false };

            EnterNamePlayerXCommand = new RelayCommand(EnterNamePlayerXExecute, EnterNamePlayerXCanExecute);
            EnterNamePlayerOCommand = new RelayCommand(EnterNamePlayerOExecute, EnterNamePlayerOCanExecute);
            ResetPointsCommand = new RelayCommand(ResetPointsExecute, ResetPointsCanExecute);
            ChangePlayer = new RelayCommand(ChangePlayerExecute, ChangePlayerCanExecute);

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
