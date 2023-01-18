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

namespace Task1
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
			int number1 = int.Parse(number1Box.Text);
			int number2 = int.Parse(number2Box.Text);
			string operation = operationBox.Text;

			if (number1Box.Text == "" || number2Box.Text == "" || operationBox.Text == "")
			{
				MessageBox.Show("Заполните все значения", "Задание 1", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}

			if (operation == "+")
			{
				Add(number1, number2);
			}
			else if (operation == "-")
			{
				Sub(number1, number2);
			}
			else if (operation == "*")
			{
				Mul(number1, number2);
			}
			else if (operation == "/")
			{
				Div(number1, number2);
			}
			else
			{
				MessageBox.Show("Ввёден неизвестный оператор. Введите одно из значений: +, -, /, *", "Задание 1", MessageBoxButton.OK, MessageBoxImage.Error);
			}

		}

		private void Add(int x, int y)
		{
			MessageBox.Show("Результат сложения: " + (x + y));
		}

		private void Sub(int x, int y)
		{
			MessageBox.Show("Результат вычитания: " + (x - y));
		}

		private void Mul(int x, int y)
		{
			MessageBox.Show("Результат умножения: " + (x * y));
		}

		private void Div(int x, int y)
		{
			if (y == 0)
			{
				MessageBox.Show("Деление на ноль запрещёно", "Задание 1", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}

			MessageBox.Show("Результат деления: " + ((decimal)x / y));
		}

	}
}