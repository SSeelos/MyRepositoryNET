using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace MyViewModels.CommunityToolkit
{
    public partial class MyAutoGeneratingObservableVM : ObservableObject
    {
        [ObservableProperty]
        string myProperty = nameof(myProperty);

        public MyAutoGeneratingObservableVM()
        {

        }
        public ICommand MyThrowingCommand => new ThrowingCommand(this);


    }
}
