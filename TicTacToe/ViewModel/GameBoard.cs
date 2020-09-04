using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Model;

namespace TicTacToe.ViewModel
{
    class GameBoard
    {
        public GameData BoardArea0 { get; private set; }
        public GameData BoardArea1 { get; private set; }
        public GameData BoardArea2 { get; private set; }
        public GameData BoardArea3 { get; private set; }
        public GameData BoardArea4 { get; private set; }
        public GameData BoardArea5 { get; private set; }
        public GameData BoardArea6 { get; private set; }
        public GameData BoardArea7 { get; private set; }
        public GameData BoardArea8 { get; private set; }

        List<GameData> BoardAreaList { get; set; }


        public GameBoard()
        {
            BoardAreaList = new List<GameData>();
            BoardAreaList.Add(BoardArea0 = new GameData());
            BoardAreaList.Add(BoardArea1 = new GameData());
            BoardAreaList.Add(BoardArea2 = new GameData());
            BoardAreaList.Add(BoardArea3 = new GameData());
            BoardAreaList.Add(BoardArea4 = new GameData());
            BoardAreaList.Add(BoardArea5 = new GameData());
            BoardAreaList.Add(BoardArea6 = new GameData());
            BoardAreaList.Add(BoardArea7 = new GameData());
            BoardAreaList.Add(BoardArea8 = new GameData());
        }

        public bool CheckForWinnerX()
        {
            List<GameData> winnerX = BoardAreaList.FindAll(WinnerX);
            if (winnerX.Count >= 3)
            {
                List<GameData> winner1 = winnerX.FindAll(Winner1);
                if (winner1.Count == 3)
                {
                    MakeItGreen(winner1);
                    return true;
                }

                List<GameData> winner2 = winnerX.FindAll(Winner2);
                if (winner2.Count == 3)
                {
                    MakeItGreen(winner2);
                    return true;
                }

                List<GameData> winner3 = winnerX.FindAll(Winner3);
                if (winner3.Count == 3)
                {
                    MakeItGreen(winner3);
                    return true;
                }

                List<GameData> winner4 = winnerX.FindAll(Winner4);
                if (winner4.Count == 3)
                {
                    MakeItGreen(winner4);
                    return true;
                }

                List<GameData> winner5 = winnerX.FindAll(Winner5);
                if (winner5.Count == 3)
                {
                    MakeItGreen(winner5);
                    return true;
                }

                List<GameData> winner6 = winnerX.FindAll(Winner6);
                if (winner6.Count == 3)
                {
                    MakeItGreen(winner6);
                    return true;
                }

                List<GameData> winner7 = winnerX.FindAll(Winner7);
                if (winner7.Count == 3)
                {
                    MakeItGreen(winner7);
                    return true;
                }

                List<GameData> winner8 = winnerX.FindAll(Winner8);
                if (winner8.Count == 3)
                {
                    MakeItGreen(winner8);
                    return true;
                }
            }
            return false;
        }

        public bool CheckForWinnerO()
        {
            List<GameData> winnerO = BoardAreaList.FindAll(WinnerO);
            if (winnerO.Count >= 3)
            {
                List<GameData> winner1 = winnerO.FindAll(Winner1);
                if (winner1.Count == 3)
                {
                    MakeItGreen(winner1);
                    return true;
                }

                List<GameData> winner2 = winnerO.FindAll(Winner2);
                if (winner2.Count == 3)
                {
                    MakeItGreen(winner2);
                    return true;
                }

                List<GameData> winner3 = winnerO.FindAll(Winner3);
                if (winner3.Count == 3)
                {
                    MakeItGreen(winner3);
                    return true;
                }

                List<GameData> winner4 = winnerO.FindAll(Winner4);
                if (winner4.Count == 3)
                {
                    MakeItGreen(winner4);
                    return true;
                }

                List<GameData> winner5 = winnerO.FindAll(Winner5);
                if (winner5.Count == 3)
                {
                    MakeItGreen(winner5);
                    return true;
                }

                List<GameData> winner6 = winnerO.FindAll(Winner6);
                if (winner6.Count == 3)
                {
                    MakeItGreen(winner6);
                    return true;
                }

                List<GameData> winner7 = winnerO.FindAll(Winner7);
                if (winner7.Count == 3)
                {
                    MakeItGreen(winner7);
                    return true;
                }

                List<GameData> winner8 = winnerO.FindAll(Winner8);
                if (winner8.Count == 3)
                {
                    MakeItGreen(winner8);
                    return true;
                }
            }
            return false;
        }

        private bool WinnerO(GameData area)
        {
            if (area.Signe == "O")
                return true;
            else
                return false;
        }

        private bool Winner1(GameData area)
        {
            if (area.IDArea == 0 || area.IDArea == 1 || area.IDArea == 2)
                return true;
            else
                return false;
        }

        private bool Winner2(GameData area)
        {
            if (area.IDArea == 3 || area.IDArea == 4 || area.IDArea == 5)
                return true;
            else
                return false;
        }

        private bool Winner3(GameData area)
        {
            if (area.IDArea == 6 || area.IDArea == 7 || area.IDArea == 8)
                return true;
            else
                return false;
        }

        private bool Winner4(GameData area)
        {
            if (area.IDArea == 0 || area.IDArea == 3 || area.IDArea == 6)
                return true;
            else
                return false;
        }

        private bool Winner5(GameData area)
        {
            if (area.IDArea == 1 || area.IDArea == 4 || area.IDArea == 7)
                return true;
            else
                return false;
        }

        private bool Winner6(GameData area)
        {
            if (area.IDArea == 2 || area.IDArea == 5 || area.IDArea == 8)
                return true;
            else
                return false;
        }

        private bool Winner7(GameData area)
        {
            if (area.IDArea == 0 || area.IDArea == 4 || area.IDArea == 8)
                return true;
            else
                return false;
        }

        private bool Winner8(GameData area)
        {
            if (area.IDArea == 2 || area.IDArea == 4 || area.IDArea == 6)
                return true;
            else
                return false;
        }

        private void MakeItGreen(List<GameData> winner)
        {
            foreach (GameData item in winner)
            {
                item.IsWinner = true;
            }
        }

        private bool WinnerX(GameData area)
        {
            if (area.Signe == "X")
                return true;
            else
                return false;
        }

        public void PlaceASigne(int index, string signe)
        {
            BoardAreaList[index].Signe = signe;
            BoardAreaList[index].IDArea = index;
        }

        public void ClearGameBoard()
        {
            foreach (GameData item in BoardAreaList)
            {
                item.Signe = null;
                item.IsWinner = false;
            }
        }

    }
}
