using MvvmCross.ViewModels;
using MyViewModels.Services;

namespace MyViewModels.MvvmCross
{
    public class MyMvxViewModel : MvxViewModel
    {
        private readonly IMyService myService;
        private string? _myProperty;
        public string? MyProperty
        {
            get => _myProperty;
            set => SetProperty(ref _myProperty, value);
        }
        public MyMvxViewModel()
        {

        }
        public MyMvxViewModel(IMyService myService)
        {
            this.myService = myService;
        }
    }
}
