using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace TicTacToe.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private GameData _playerX;

        public GameData PlayerX
        {
            get { return _playerX; }
            set { _playerX = value; }
        }

        private GameData _playerO;

        public GameData PlayerO
        {
            get { return _playerO; }
            set { _playerO = value; }
        }

        public ICommand EnterNamePlayerXCommand { get; set; }
        public ICommand EnterNamePlayerOCommand { get; set; }
        public ICommand ResetPointsCommand { get; set; }



        public MainViewModel()
        {
            PlayerX = new GameData { Name = "Hallo X", Points = 12, InAction = true };
            PlayerO = new GameData { Name = "Hallo O", Points = 4, InAction = false };
        }

    }
}
