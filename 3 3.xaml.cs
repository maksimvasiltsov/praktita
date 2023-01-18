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

namespace Work3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Double a = Convert.ToDouble(number.Text);
            if (0 <= a && a < 15)
            {
                l.Content = "0 - 14";

            }
            else if (15 <= a && a < 36)
            {
                l.Content = "15 - 35";
            }
            else if (36 <= a && a < 51)
            {
                l.Content = "36 - 50";
            }
            else if (50 <= a && a < 101)
            {
                l.Content = "50 - 100";
            }
            else
            {
                l.Content = "Цифра/число не входит ни в один из промежутков";
            }
        }
    }
}