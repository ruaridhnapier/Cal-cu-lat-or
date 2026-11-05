using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cal_cu_la_tor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int button = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(num1.Text, @"^[Z0-9 +-]+$") == true)
            {
                int INT1 = Int32.Parse(num1.Text);
                int INT2 = Int32.Parse(num2.Text);
                if (button == 1)
                {
                    output.Content = INT1 * INT2;
                }
                else
                {
                    if (button == 2)
                    {
                        output.Content = INT1 / INT2;
                    }
                    else
                    {
                        if (button == 3)
                        {
                            output.Content = INT1 + INT2;
                        }
                        else
                        {
                            if (button == 4)
                            {
                                output.Content = INT1 - INT2;
                            }
                        }
                    }
                }
            } else
            {
                output.Content = "Error";
            }

        }
        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            button = 1;
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            button = 2;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            button = 3;
        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            button = 4;
        }
    }
}