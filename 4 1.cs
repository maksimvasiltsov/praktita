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

namespace lab4._1
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
            int sum = 0;
            string cont = "";
            int i = Convert.ToInt32(num1.Text);
            int n = Convert.ToInt32(num2.Text);
            for (; i != n + 1; i++)
            {
                sum += i;
                if (i % 2 != 0)
                {
                    cont += Convert.ToString(i);
                    cont += " ";
                }
            }
            Ans1.Content = sum;
            Ans2.Content = cont;
        }
    }
}
