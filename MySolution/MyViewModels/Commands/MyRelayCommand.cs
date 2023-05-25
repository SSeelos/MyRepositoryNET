using System.Windows.Input;

namespace MyViewModels
{
    public class MyRelayCommand : ICommand
    {
        private Action<object?> _action;
        private Func<object?, bool> _predicate;
        public event EventHandler? CanExecuteChanged;

        public MyRelayCommand(Action<object> action, Func<object, bool> predicate = null)
        {
            _action = action;
            _predicate = predicate;
        }
        public bool CanExecute(object? parameter)
            => _predicate == null || _predicate(parameter);

        public void Execute(object? parameter)
            => _action(parameter);
    }
}
