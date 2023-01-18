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

namespace work4
{
    /// <summary> 
    /// Логика взаимодействия для Window3.xaml 
    /// </summary> 
    public partial class MainWindow : Window
    {
        private const string password = "6098";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            if (BOX.Text == password)
            {
                MessageBox.Show("Контакт", "Секретное слово");
            }
            else
            {
                MessageBox.Show("Неверный пароль", "Ошибка");
            }
        }
    }
}