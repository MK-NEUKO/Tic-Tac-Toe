using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.ViewModel;

namespace TicTacToe.Model
{
    class GameData : ViewModelBase
    {
        private string _boardArea1;

        public string BoardArea1
        {
            get { return _boardArea1; }
            set { SetProperty(ref _boardArea1, value); }
        }

        private string _boardArea2;

        public string BoardArea2
        {
            get { return _boardArea2; }
            set { SetProperty(ref _boardArea2, value); }
        }

        private string _boardArea3;

        public string BoardArea3
        {
            get { return _boardArea3; }
            set { SetProperty(ref _boardArea3, value); }
        }

        private string _boardArea4;

        public string BoardArea4
        {
            get { return _boardArea4; }
            set { SetProperty(ref _boardArea4, value); }
        }

        private string _boardArea5;

        public string BoardArea5
        {
            get { return _boardArea5; }
            set { SetProperty(ref _boardArea5, value); }
        }

        private string _boardArea6;

        public string BoardArea6
        {
            get { return _boardArea6; }
            set { SetProperty(ref _boardArea6, value); }
        }

        private string _boardArea7;

        public string BoardArea7
        {
            get { return _boardArea7; }
            set { SetProperty(ref _boardArea7, value); }
        }

        private string _boardArea8;

        public string BoardArea8
        {
            get { return _boardArea8; }
            set { SetProperty(ref _boardArea8, value); }
        }

        private string _boardArea9;

        public string BoardArea9
        {
            get { return _boardArea9; }
            set { SetProperty(ref _boardArea9, value); }
        }
    }
}
