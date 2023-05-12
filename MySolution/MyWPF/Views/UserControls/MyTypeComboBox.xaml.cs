using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace MyWPF.Views.UserControls
{
    /// <summary>
    /// Interaction logic for MyTypeComboBox.xaml
    /// </summary>
    public partial class MyTypeComboBox : UserControl, INotifyPropertyChanged
    {
        public static readonly DependencyProperty BaseTypeProperty =
            DependencyProperty.Register(
                nameof(BaseType),
                typeof(Type),
                typeof(MyTypeComboBox),
                new PropertyMetadata(null, OnBaseTypeChanged));

        private static void OnBaseTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not MyTypeComboBox comboBox)
                return;

            if (e.NewValue is not Type typeValue)
                return;

            RefreshAssignableTypes(comboBox, typeValue);
            comboBox.SelectedType = typeValue;
        }

        public Type BaseType
        {
            get => (Type)GetValue(BaseTypeProperty);
            set => SetValue(BaseTypeProperty, value);
        }

        private Type _type;
        public Type SelectedType
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Type> AssignableTypes { get; set; }
            = new ObservableCollection<Type>();
        public MyTypeComboBox()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private static void RefreshAssignableTypes(MyTypeComboBox comboBox, Type baseType)
        {
            if (baseType == null)
                return;

            comboBox.AssignableTypes.Clear();
            var types = baseType?.Assembly
                .GetTypes()
                .Where(t => baseType.IsAssignableFrom(t))
                .OrderBy(t => t.Name);

            foreach (var type in types)
            {
                comboBox.AssignableTypes.Add(type);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
