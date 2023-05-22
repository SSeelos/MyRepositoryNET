using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MyWPF.Views.UserControls
{
    /// <summary>
    /// Interaction logic for MyEnumComboBox.xaml
    /// </summary>
    public partial class MyEnumComboBox : UserControl
    {
        #region EnumType
        public static readonly DependencyProperty MyEnumType_DP
            = DependencyProperty.Register(
                nameof(MyEnumType), typeof(Type),
                typeof(MyEnumComboBox),
                new PropertyMetadata(null, OnMyEnumTypeChanged));

        public Type MyEnumType
        {
            get => (Type)GetValue(MyEnumType_DP);
            set => SetValue(MyEnumType_DP, value);
        }

        private static void OnMyEnumTypeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            if (!(obj is MyEnumComboBox owner) ||
                !(args.NewValue is Type type))
                return;

            owner.MyItems.Clear();

            var enumValues = Enum.GetValues(type)
                .Cast<object>()
                .OrderBy(value => value.ToString());

            foreach (var value in enumValues)
            {
                string str = value.ToString();
                owner.MyItems.Add(str);
            }

            //init default selection
            owner.SelectedString = owner.MyItems.FirstOrDefault();
        }
        public ObservableCollection<string> MyItems { get; set; }
            = new ObservableCollection<string>();
        #endregion

        #region SelectedItem

        public static readonly DependencyProperty SelectedString_DP
            = DependencyProperty.Register(
                nameof(SelectedString), typeof(string),
                typeof(MyEnumComboBox),
                new PropertyMetadata(string.Empty));

        public string SelectedString
        {
            get => (string)GetValue(SelectedString_DP);
            set => SetValue(SelectedString_DP, value);
        }
        #endregion


        public MyEnumComboBox()
        {
            InitializeComponent();
        }
    }
}
