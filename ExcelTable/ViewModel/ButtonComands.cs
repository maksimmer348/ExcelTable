using System;
using System.Windows.Input;

namespace ExcelTable.ViewModel
{
    public class ButtonComands : ICommand//класс находится в ViewModel прослойка междду View и Model
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }

        
    }
}