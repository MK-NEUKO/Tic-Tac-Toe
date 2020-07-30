using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.ViewModel;

namespace TicTacToe
{
    class GameData : ViewModelBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty<string>(ref _name, value); }
        }

        private int _points;

        public int Points
        {
            get { return _points; }
            set { SetProperty<int>(ref _points, value); }
        }

        private bool _inAction;

        public bool InAction
        {
            get { return _inAction; }
            set { SetProperty<bool>(ref _inAction, value); }
        }

    }
}
