using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.ViewModel
{
    class GameLogic : ViewModelBase
    {
        private PlayerData gameData;

        public PlayerData GameData
        {
            get { return gameData; }
            set { gameData = value; }
        }

    }
}
