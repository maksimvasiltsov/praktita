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

namespace _3._2
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
            double a = Convert.ToDouble(TBA.Text);
            double b = Convert.ToDouble(TBB.Text);
            string op = TBop.Text;
            switch (op)
            {
                case "+":
                    l.Content = a + b;
                    break;
                case "-":
                    l.Content = a - b;
                    break;
                case "*":
                    l.Content = a * b;
                    break;
                case "/":
                    if (b != 0)
                        l.Content = a / b;
                    else
                        l.Content = "error";
                    break;
                default:
                    l.Content = "error";
                    break;
            }

        }
    }
}