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

namespace Homework3_Part1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String firstName = fn.Text;
            String lastName = ln.Text;

            String first2 = (firstName.Substring(1, firstName.Length - 1) + firstName.Substring(0,1) + "ay").ToLower();
            String last2 = (lastName.Substring(1, lastName.Length - 1) + lastName.Substring(0, 1) + "ay").ToLower();

            String result = first2.Substring(0,1).ToUpper() + first2.Substring(1, first2.Length - 1) + " " + last2.Substring(0, 1).ToUpper() + last2.Substring(1, last2.Length - 1);
            Output.Content = result;
        }
    }
}