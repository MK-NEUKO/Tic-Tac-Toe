using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public GameData PlayerX = new GameData { Name = "Horst", Points = 12, InAction = true };
        public GameData PlayerO = new GameData { Name = "Wurst", Points = 35, InAction = false };

        public MainViewModel()
        {
            
        }
    }

}
