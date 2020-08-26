using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.ViewModel;

namespace TicTacToe.Model
{
    class GameData : ViewModelBase
    {
        private string _signe;

        public string Signe
        {
            get { return _signe; }
            set { SetProperty(ref _signe, value); }
        }

        private bool _isWinner;

        public bool IsWinner
        {
            get { return _isWinner; }
            set { SetProperty(ref _isWinner, value); }
        }

        private string _iD;

        public string ID
        {
            get { return _iD; }
            set { SetProperty(ref _iD, value); }
        }

    }
}
