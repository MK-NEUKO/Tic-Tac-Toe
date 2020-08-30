using System;
using System.Collections.Generic;
using TicTacToe.Model;

namespace TicTacToe.ViewModel
{
    partial class MainViewModel
    {
        public class Winner
        {
            public GameData BoardArea0 { get; set; }
            public GameData BoardArea1 { get; set; }
            public GameData BoardArea2 { get; set; }
            public GameData BoardArea3 { get; set; }
            public GameData BoardArea4 { get; set; }
            public GameData BoardArea5 { get; set; }
            public GameData BoardArea6 { get; set; }
            public GameData BoardArea7 { get; set; }
            public GameData BoardArea8 { get; set; }

            List<GameData> BoardAreaList = new List<GameData>();


            public Winner()
            {
                BoardArea0 = new GameData();
                BoardArea1 = new GameData();
                BoardArea2 = new GameData();
                BoardArea3 = new GameData();
                BoardArea4 = new GameData();
                BoardArea5 = new GameData();
                BoardArea6 = new GameData();
                BoardArea7 = new GameData();
                BoardArea8 = new GameData();

                BoardAreaList.Add(BoardArea0);
                BoardAreaList.Add(BoardArea1);
                BoardAreaList.Add(BoardArea2);
                BoardAreaList.Add(BoardArea3);
                BoardAreaList.Add(BoardArea4);
                BoardAreaList.Add(BoardArea5);
                BoardAreaList.Add(BoardArea6);
                BoardAreaList.Add(BoardArea7);
                BoardAreaList.Add(BoardArea8);
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


            public void PlaceASigne(string name, string signe)
            {
                double index = Char.GetNumericValue(name, 9);
                int i = (int)index;
                BoardAreaList[i].Signe = signe;
                BoardAreaList[i].IDArea = i;
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
}
