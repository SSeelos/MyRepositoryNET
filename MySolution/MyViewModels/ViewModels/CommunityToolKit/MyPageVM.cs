using CommunityToolkit.Mvvm.ComponentModel;

namespace MyViewModels
{
    public partial class MyPageVM : ObservableObject
    {
        [ObservableProperty]
        string myPropertyA;
        [ObservableProperty]
        string myPropertyB;

        public MyPageVM()
        {

        }
    }
}
