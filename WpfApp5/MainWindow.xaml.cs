using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(TextBox1.Text, out double a))
            {
                MessageBox.Show("Enter number");
                TextBox1.Clear();
                TextBox1.Focus();
                return;
            }
            if (!double.TryParse(TextBox2.Text, out double b))
            {
                MessageBox.Show("Enter number");
                TextBox2.Clear();
                TextBox2.Focus();
                return;
            }
            Func<double, double, double> f1 = null;
            string op = "";
            if (RadioSaberi.IsChecked == true)
            {
                f1 = (x, y) => x + y;
                op = "+";
            }
            else if (RadioOduzmi.IsChecked == true)
            {
                f1 = (x, y) => x - y;
                op = "-";
            }
            else if (RadioPomnozi.IsChecked == true)
            {
                f1 = (x, y) => x * y;
                op = "*";
            }
            else if (RadioPodeli.IsChecked == true)
            {
                f1 = (x, y) => x / y;
                op = "/";
            }
            else
            {
                MessageBox.Show("Pick operation");
                return;
            }
            double rezultat = f1(a, b);
            TextBox3.AppendText($"{a} {op} {b} = {rezultat}\n");
        }
    }
}
