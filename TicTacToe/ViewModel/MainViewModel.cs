﻿using System;
using System.Collections.Generic;
using System.Printing;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using TicTacToe.Model;

namespace TicTacToe.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public PlayerData PlayerX { get; set; }
        public PlayerData PlayerO { get; set; }
        public GameBoard Board { get; set; }


        public ICommand EnterNamePlayerXCommand { get; set; }
        public ICommand EnterNamePlayerOCommand { get; set; }
        public ICommand ResetPointsCommand { get; set; }
        public ICommand PlaceASigneCommand { get; set; }



        public MainViewModel()
        {
            PlayerX = new PlayerData { /*Name = "",*/ Points = 12, InAction = true };
            PlayerO = new PlayerData { /*Name = "",*/ Points = 4, InAction = false };
            Board = new GameBoard();
           
            EnterNamePlayerXCommand = new RelayCommand(EnterNamePlayerXExecute, EnterNamePlayerXCanExecute);
            EnterNamePlayerOCommand = new RelayCommand(EnterNamePlayerOExecute, EnterNamePlayerOCanExecute);
            ResetPointsCommand = new RelayCommand(ResetPointsExecute, ResetPointsCanExecute);
            PlaceASigneCommand = new RelayCommand(PlaceASigneExecute, PlaceASigneCanExecute);
        }


        private bool PlaceASigneCanExecute(object obj)
        {
            if (obj is Button)
                return true;
            else
                // Fehlermeldung
                return false;
        }

        private void PlaceASigneExecute(object obj)
        {
            if (obj is Button value)
            {
                if (PlayerX.InAction)
                {
                    Board.PlaceASigne(value.Name, "X");
                    PlayerO.InAction = true;
                    PlayerX.InAction = false;
                }
                else
                {
                    Board.PlaceASigne(value.Name, "O");
                    PlayerO.InAction = false;
                    PlayerX.InAction = true;
                }
            }
        }

        public class GameBoard
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


            public GameBoard()
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


            public void PlaceASigne(string name, string signe)
            {
                double index = Char.GetNumericValue(name, 9);
                int i = (int)index;
                BoardAreaList[i].Signe = signe; 
            }

        }





        private bool ResetPointsCanExecute(object obj)
        {
            return true;
        }

        private void ResetPointsExecute(object obj)
        {
            PlayerX.Points = 0;
            PlayerO.Points = 0;
        }

        private bool EnterNamePlayerOCanExecute(object obj)
        {
            if (obj != null)
            {
                TextBox textBox = obj as TextBox;
                return textBox.Text != "";
            }
            return false;
        }

        private void EnterNamePlayerOExecute(object obj)
        {
            TextBox textBox = obj as TextBox;
            PlayerO.Name = textBox.Text;
        }

        private bool EnterNamePlayerXCanExecute(object obj)
        {
            if (obj != null)
            {
                TextBox textBox = obj as TextBox;
                return textBox.Text != "";
            }
            return false;
        }

        private void EnterNamePlayerXExecute(object obj)
        {
            TextBox textBox = obj as TextBox;
            PlayerX.Name = textBox.Text;
        }
    }
}
