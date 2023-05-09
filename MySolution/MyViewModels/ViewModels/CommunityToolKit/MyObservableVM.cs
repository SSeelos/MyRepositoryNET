using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace MyViewModels.CommunityToolkit
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
        public ICommand MyThrowingCommand => new ThrowingCommand(this);

        public ICommand MyCommand => new MyCommand(this);
    }
}
