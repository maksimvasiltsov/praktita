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

namespace lab4._5
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
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(num.Text);
            if (i <= 5)
            {
                ans.Content = Convert.ToString(10);
                ans.Content += "%";
            }
            else if (i < 10)
            {
                ans.Content = Convert.ToString(15);
                ans.Content += "%";
            }
            else if (i < 15)
            {
                ans.Content = Convert.ToString(25);
                ans.Content += "%";
            }
            else if (i < 20)
            {
                ans.Content = Convert.ToString(35);
                ans.Content += "%";
            }
            else if (i < 25)
            {
                ans.Content = Convert.ToString(45);
                ans.Content += "%";
            }
            else if (i >= 25)
            {
                ans.Content = Convert.ToString(50);
                ans.Content += "%";
            }
        }
    }
}
