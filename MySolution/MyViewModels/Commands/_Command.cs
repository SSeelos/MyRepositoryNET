using System.Windows.Input;

namespace MyViewModels
{
    public abstract class _Command : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        public virtual bool CanExecute(object? parameter) => true;
        public void Execute(object? parameter)
        {
            try
            {
                TryExecute(parameter);
            }
            catch
            {
                //todo
            }
        }
        protected abstract void TryExecute(object? parameter);
    }
}
