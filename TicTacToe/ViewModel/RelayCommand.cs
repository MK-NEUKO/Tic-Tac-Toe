using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace TicTacToe.ViewModel
{
    class RelayCommand : ICommand
    {
        public readonly Action<object> _executeHandler;
        public readonly Predicate<object> _canExecuteHandler;

        public RelayCommand(Action<object> execute) : this(execute, null)
        { }

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("Execute kann nicht null sein.");
            }
            _executeHandler = execute;
            _canExecuteHandler = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            _executeHandler(parameter);
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecuteHandler == null)
            {
                return true;
            }
            return _canExecuteHandler(parameter);
        }
    }
}
