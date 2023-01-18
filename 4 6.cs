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

namespace lab4._6
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
            try
            {
                int a = Convert.ToInt32(txt.Text);
                int b = 1;
                int c = 0;
            A1:
                if (c < a)
                {
                    goto A2;
                }
                else
                {
                    goto A3;
                }
            A2:
                c++;
                b *= c;
                goto A1;
            A3:
                abc.Text = "" + b;
            }
            catch
            {
                abc.Text = "введите число";
            }
        }
    }
}