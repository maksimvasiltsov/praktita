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

namespace _3._1
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


            String a = Convert.ToString(Word.Text);
            switch (a)
            {


                case "град":
                    EnWord.Content = "hail";
                    break;
                case "дождь":
                    EnWord.Content = "rain";
                    break;
                case "шторм":
                    EnWord.Content = "storm";
                    break;
                case "Туман":
                    EnWord.Content = "Fog";
                    break;
                case "Солнечно":
                    EnWord.Content = "Sunny";
                    break;
                case "Тепло":
                    EnWord.Content = "Warm";
                    break;
                case "Холодно":
                    EnWord.Content = "Coldly";
                    break;
                case "Снежно":
                    EnWord.Content = "Snowy";
                    break;
                case "Ясно":
                    EnWord.Content = "fair";
                    break;
                case "метель":
                    EnWord.Content = "blizzard";
                    break;
                default:
                    EnWord.Content = "Введите слово из списка";
                    break;
            }
        }
    }
}
