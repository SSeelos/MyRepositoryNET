using MyViewModels;
using System.Windows.Controls;

namespace MyWPF.Views.Pages
{
    /// <summary>
    /// Interaction logic for MyPage.xaml
    /// </summary>
    public partial class MyPage : Page
    {
        public MyPage()
        {
            DataContext = new MyPageVM();
            InitializeComponent();
        }
    }
}
