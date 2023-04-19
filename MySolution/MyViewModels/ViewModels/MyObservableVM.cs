using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace MyViewModels
{
    public class MyObservableVM : ObservableObject
    {
        private const string myDefault = nameof(myDefault);
        private string _myProperty = myDefault;
        public string MyProperty
        {
            get => _myProperty;
            set => SetProperty(ref _myProperty, value);
        }

        public MyObservableVM()
        {

        }

        public ICommand MyCommand => new MyCommand(this);
    }
}
