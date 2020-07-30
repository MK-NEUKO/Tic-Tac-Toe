using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public GameData PlayerX;
        public GameData PlayerO;

        public MainViewModel()
        {
            PlayerX = new GameData { Name = "Hallo X", Points = 12, InAction = true };
            PlayerO = new GameData { Name = "Hallo O", Points = 4, InAction = false };
        }


    }
}
