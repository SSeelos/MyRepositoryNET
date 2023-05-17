using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyWPF.Views.UserControls
{
    /// <summary>
    /// Interaction logic for MyUserControlV.xaml
    /// </summary>
    public partial class MyUserControlV : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private string myVar;
        public string MyProperty
        {
            get => myVar;
            set
            {
                myVar = value;
                OnPropertyChanged();
            }
        }
        public ICommand MyCommand => new RelayCommand(() =>
        {
            MyProperty = (MyProperty != nameof(MyCommand))
            ? nameof(MyCommand)
            : nameof(MyProperty);
        });

        public MyUserControlV()
        {
            InitializeComponent();
        }
    }
}
