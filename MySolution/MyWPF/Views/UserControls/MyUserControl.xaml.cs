using System.Windows;
using System.Windows.Controls;

namespace MyWPF.Views.UserControls
{
    /// <summary>
    /// Interaction logic for MyUserControl.xaml
    /// </summary>
    public partial class MyUserControl : UserControl
    {
        public static readonly DependencyProperty MyDependencyProperty =
            DependencyProperty.Register(
                nameof(MyPropertyWrapper), typeof(string),
                typeof(MyUserControl),
                new PropertyMetadata(default(string), OnPropertyChangedCallback));

        private static void OnPropertyChangedCallback(DependencyObject dObj, DependencyPropertyChangedEventArgs args)
        {
            if (dObj is not MyUserControl owner ||
                args.NewValue is not string value)
                return;

            //...
        }

        /// <summary>
        /// wrapper for <see cref="MyDependencyProperty"/>
        /// </summary>
        public string MyPropertyWrapper
        {
            get => (string)GetValue(MyDependencyProperty);
            set => SetValue(MyDependencyProperty, value);
        }

        internal static readonly DependencyPropertyKey MyDependencyPropertyKey
            = DependencyProperty.RegisterReadOnly(
                nameof(MyReadOnlyPropertyWrapper), typeof(string),
                typeof(MyUserControl),
                new PropertyMetadata(default(string)));

        public string MyReadOnlyPropertyWrapper
            => (string)GetValue(MyDependencyPropertyKey.DependencyProperty);

        public MyUserControl()
        {
            InitializeComponent();
        }
    }
}
