using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.ViewModel;

namespace TicTacToe.Model
{
    public class Player// : TicTacToeBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _points;
        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }


        private bool _redyToPlay;
        public bool RedyToPlay
        {
            get { return _redyToPlay; }
            set { _redyToPlay = value; }
        }
    }
}
