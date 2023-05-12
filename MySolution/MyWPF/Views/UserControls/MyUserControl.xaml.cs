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
                               nameof(MyPropertyWrapper),
                               typeof(string),
                               typeof(MyUserControl),
                               new PropertyMetadata(default(string), OnPropertyChangedCallback));

        private static void OnPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not MyUserControl myUserControl)
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

        public MyUserControl()
        {
            InitializeComponent();

        }
    }
}
