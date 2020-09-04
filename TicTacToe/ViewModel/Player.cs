using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Model;

namespace TicTacToe.ViewModel
{
    class Player
    {
        private PlayerData PlayerX;
        private PlayerData PlayerO;

        public Player(PlayerData PlayerX, PlayerData PlayerO)
        {
            this.PlayerX = PlayerX;
            this.PlayerO = PlayerO;
        }

        public void ChangePlayer()
        {
            if (PlayerX.InAction)
            {
                PlayerX.InAction = false;
                PlayerO.InAction = true;
            }
            if (PlayerO.InAction)
            {
                PlayerO.InAction = false;
                PlayerX.InAction = true;
            }
        }
    }
}
