#nullable enable
using System;
using System.Windows.Input;

namespace ExcelTable.ViewModel
{
    public class ButtonComands : ICommand//класс находится в ViewModel прослойка междду View и Model
    {
        private Action<object> execute;//сама функция ктороую мы будем передават в параметры
                                       //конструктора ...Action<object> execute... вот сюда 
        private Func<object, bool> canExecute;//а здесь иддет ублево заначние можно ли выполнять эту функциию
        //или нельзя с помощью этой функциии можно делать напримре усови я при которой эта кнопкка будет активна

        public event EventHandler? CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value; 

            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public ButtonComands(Action<object> execute, Func<object, bool> canExecute)//
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public bool CanExecute(object? parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            if (parameter != null) execute(parameter);
        }

        
    }
}