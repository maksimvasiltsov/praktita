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

namespace WpfApp2
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
            try
            {
                int a = Convert.ToInt32(TXT.Text);
                int b = 1;
                int c = 0;
                do
                {
                    c++;
                    b *= c;
                }
                while (c < a);
                EE.Content = "" + b;
            }
            catch
            {
                EE.Content = "ошибка";
            }
        }
    }
}