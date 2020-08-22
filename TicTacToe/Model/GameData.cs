using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.ViewModel;

namespace TicTacToe.Model
{
    class GameData : ViewModelBase
    {
        private string[] _gameBoard;

        public string[] GameBoard
        {
            get { return _gameBoard; }
            set { SetProperty<string[]>(ref _gameBoard, value); }
        }

    }
}
