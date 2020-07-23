﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TicTacToe.ViewModel
{
    public abstract class TicTacToeViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void SetProperty<T>(ref T storage, T value, [CallerMemberName] string property = null)
        {
            if (Object.Equals(storage, value)) return;
            storage = value;
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
