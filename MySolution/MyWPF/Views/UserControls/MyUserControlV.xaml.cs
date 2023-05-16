using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyWPF.Views.UserControls
{
    /// <summary>
    /// Interaction logic for MyUserControlV.xaml
    /// </summary>
    public partial class MyUserControlV : UserControl, INotifyPropertyChanged
    {
        private string myVar;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string MyProperty
        {
            get => myVar;
            set
            {
                myVar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyProperty)));
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
