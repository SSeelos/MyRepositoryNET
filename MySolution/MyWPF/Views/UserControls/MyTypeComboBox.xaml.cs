using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MyWPF.Views.UserControls
{
    /// <summary>
    /// Interaction logic for MyTypeComboBox.xaml
    /// </summary>
    public partial class MyTypeComboBox : UserControl
    {
        public static readonly DependencyProperty BaseType_DP
            = DependencyProperty.Register(
                nameof(BaseType), typeof(Type),
                typeof(MyTypeComboBox),
                new PropertyMetadata(null, OnBaseTypeChanged));

        public Type BaseType
        {
            get => (Type)GetValue(BaseType_DP);
            set => SetValue(BaseType_DP, value);
        }

        private static void OnBaseTypeChanged(DependencyObject dObj, DependencyPropertyChangedEventArgs args)
        {
            if (!(dObj is MyTypeComboBox owner) ||
                !(args.NewValue is Type))
                return;

            ResetAssignableTypes(owner);
            owner.SelectedType = owner.BaseType;
        }

        public static readonly DependencyProperty SelectedType_DP =
            DependencyProperty.Register(
                nameof(SelectedType), typeof(Type),
                typeof(MyTypeComboBox),
                new PropertyMetadata(null));

        public Type SelectedType
        {
            get => (Type)GetValue(SelectedType_DP);
            set => SetValue(SelectedType_DP, value);
        }

        public ObservableCollection<Type> AssignableTypes { get; set; }
            = new ObservableCollection<Type>();
        public MyTypeComboBox()
        {
            InitializeComponent();
            this.MyComboBox.DataContext = this;
        }

        private static void ResetAssignableTypes(MyTypeComboBox comboBox)
        {
            comboBox.AssignableTypes.Clear();
            var types = comboBox.BaseType?.Assembly
                .GetTypes()
                .Where(t => comboBox.BaseType.IsAssignableFrom(t))
                .OrderBy(t => t.Name);

            if (types == null)
                return;

            foreach (var type in types)
            {
                comboBox.AssignableTypes.Add(type);
            }
        }
    }
}
