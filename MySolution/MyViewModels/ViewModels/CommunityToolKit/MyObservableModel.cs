using CommunityToolkit.Mvvm.ComponentModel;

namespace MyViewModels
{
    public partial class MyObservableModel : ObservableObject
    {
        [ObservableProperty]
        string myPropertyA;
        [ObservableProperty]
        string myPropertyB;
    }
}
