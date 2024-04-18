using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Start_Click(object sender, RoutedEventArgs e)
        {
            reset.IsEnabled = false;
            for (int i = 0; i < 10; i++)
            {
                loding.Value += 10;
                await Task.Delay(100);
            }
            reset.IsEnabled = true;
        }
        private async void Reset_Click(object sender, RoutedEventArgs e)
        {
            loding.Value = 0;
        }

    }
}