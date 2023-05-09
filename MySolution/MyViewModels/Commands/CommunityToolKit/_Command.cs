using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace MyViewModels.CommunityToolkit
{
    public abstract class _Command : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter) => true;
        protected abstract void TryExecute(object? parameter);
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

    }

    /// <summary>
    /// <see cref="ICommand"/> with a reference to an <see cref="ObservableObject"/> (VM, ...)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class _Command<T> : ICommand
        where T : ObservableObject
    {
        protected T? observable;
        public event EventHandler? CanExecuteChanged;

        public _Command(T observable)
        {
            this.observable = observable;
        }

        public virtual bool CanExecute(object? parameter) => true;
        protected abstract void TryExecute(object? parameter);
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
    }
}
