using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class GameData 
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

        private bool _inAction;

        public bool InAction
        {
            get { return _inAction; }
            set { _inAction = value; }
        }

    }
}
