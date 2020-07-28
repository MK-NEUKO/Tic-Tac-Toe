using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.ViewModel;

namespace TicTacToe.Model
{
    public class PlayerData// : TicTacToeBase
    {
        private string _name;
        public string Name 
        {
            get => _name;
            set => _name = value;
            //get { return _name; }
            //set { SetProperty<string>(ref _name, value); } 
        }

        private int _points;
        public int Points
        {
            get => _points;
            set => _points = value;
            //get { return _points; }
            //set { SetProperty<int>(ref _points, value); }
        }

        private bool _readyToPlay;
        public bool ReadyToPlay 
        {
            get => _readyToPlay;
            set => _readyToPlay = value;
            //get { return _readyToPlay; }
            //set {SetProperty<bool>(ref _readyToPlay, value); } 
        }

    }
}
