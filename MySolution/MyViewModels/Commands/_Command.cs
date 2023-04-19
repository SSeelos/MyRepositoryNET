using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace MyViewModels.Commands
{
    public abstract class _Command : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter) => true;

        public abstract void Execute(object? parameter);
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
        public abstract void Execute(object? parameter);
    }
}
