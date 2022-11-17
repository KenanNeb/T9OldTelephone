using System.Windows;
using T9OldTelephone.ViewModels;

namespace T9OldTelephone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel() { T9Keyboard = this };
        }
    }
}
