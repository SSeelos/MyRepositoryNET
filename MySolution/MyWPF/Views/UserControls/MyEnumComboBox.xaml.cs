using MyClassLibraryNetStandard2_0;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace MyWPF.Views.UserControls
{
    /// <summary>
    /// Interaction logic for MyEnumComboBox.xaml
    /// </summary>
    public partial class MyEnumComboBox : UserControl, INotifyPropertyChanged
    {
        private MyEnum _myEnumValue;
        public MyEnum MyEnumValue
        {
            get => _myEnumValue;
            set
            {
                _myEnumValue = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<MyEnum> MyEnumValues { get; set; }
        //combobox that binds to an enum
        public MyEnumComboBox()
        {
            InitializeComponent();
            this.DataContext = this;

            var enumValue = Enum.GetValues(typeof(MyEnum))
                .Cast<MyEnum>()
                .OrderBy(x => x.ToString());

            this.MyEnumValues = new ObservableCollection<MyEnum>(enumValue);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
