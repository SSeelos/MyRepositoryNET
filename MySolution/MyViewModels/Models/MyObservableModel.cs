using CommunityToolkit.Mvvm.ComponentModel;

namespace MyViewModels.Models
{
    public partial class MyObservableModel : ObservableObject
    {
        [ObservableProperty]
        string myPropertyA;
        [ObservableProperty]
        string myPropertyB;
    }
}
