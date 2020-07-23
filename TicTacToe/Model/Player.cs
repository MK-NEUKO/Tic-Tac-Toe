using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.ViewModel;

namespace TicTacToe.Model
{
    public class Player : TicTacToeViewModelBase
    {
        private string _name;
        public string Name 
        {
            get { return _name; }
            set { SetProperty<string>(ref _name, value); } 
        }

    }
}
