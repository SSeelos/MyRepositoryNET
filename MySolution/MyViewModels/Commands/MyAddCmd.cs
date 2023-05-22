using System.Collections.ObjectModel;

namespace MyViewModels
{
    public class MyAddCmd<T> : _Command
    {
        ObservableCollection<T> collection;
        T item;
        /// <summary>
        /// add item to collection
        /// </summary>
        public MyAddCmd(ObservableCollection<T> collection, T item)
        {
            this.collection = collection;
            this.item = item;
        }
        protected override void TryExecute(object? parameter)
        {
            this.collection.Add(item);
        }
    }
}
