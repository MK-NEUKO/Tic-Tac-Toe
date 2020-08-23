using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.ViewModel;

namespace TicTacToe.Model
{
    class GameData : ViewModelBase
    {
        private string[] _array;

        public string[] Array
        {
            get { return _array; }
            set { SetProperty<string[]>(ref _array, value); }
        }

    }
}
