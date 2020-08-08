using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.ViewModel;

namespace TicTacToe.Model
{
    class GameData : ViewModelBase
    {
        private char[] _gameBoard;

        public char[] GameBoard
        {
            get { return _gameBoard; }
            set { SetProperty<char[]>(ref _gameBoard, value); }
        }

    }
}
