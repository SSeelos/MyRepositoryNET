using System.Collections.ObjectModel;

namespace MyViewModels
{
    public class MyObservableCollectionCmd<T> : _Command
    {
        ObservableCollection<T> collection;
        Action<ObservableCollection<T>> action;
        public MyObservableCollectionCmd(ObservableCollection<T> collection, Action<ObservableCollection<T>> action)
        {
            this.collection = collection;
            this.action = action;
        }

        protected override void TryExecute(object? parameter)
        {
            action?.Invoke(this.collection);
        }
    }
}
