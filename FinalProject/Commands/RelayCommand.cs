using System.Windows.Input;

namespace FinalProject.Commands;

public class RelayCommand : ICommand
{

    private Action<object> _execute;
    private Func<object, bool> _canExecute;

    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;

    }

    //public bool CanExecute(object parameter)
    //{
    //    return _canExecute == null || _canExecute(parameter);
    //}

    //public void Execute(object parameter)
    //{
    //    _execute(parameter);
    //}

    public bool CanExecute(object? parameter)
    {
        if(_canExecute is null)
            return true;
        return _canExecute(parameter);
    }

    public void Execute(object? parameter)
    {
        if (_execute is not null)
        {
            _execute(parameter);
        }
    }
}
