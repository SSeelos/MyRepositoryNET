using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyViewModels.Models
{
    public class _Model : INotifyPropertyChanging, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public event PropertyChangingEventHandler? PropertyChanging;
        /// <summary>
        /// Call before a property value is changing
        /// to notify clients
        /// </summary>
        protected virtual void OnPropertyChanging([CallerMemberName] string? propertyName = null)
            => PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        /// <summary>
        /// Call after a property value has changed
        /// to notify clients
        /// </summary>
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
