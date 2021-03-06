﻿using System;
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

        private int _iDArea;

        public int IDArea
        {
            get { return _iDArea; }
            set { SetProperty(ref _iDArea, value); }
        }

    }
}
