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

namespace Task3
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
			if (numberBox.Text == "")
			{
				MessageBox.Show("Укажите число для анализа", "Анализ числа", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			int number = int.Parse(numberBox.Text);
			NumberInfo(number);
		}

		private void NumberInfo(int number)
		{
			// Является ли введенное число положительным или отрицательным
			string negType;
			if (number >= 0)
				negType = "Положительное";
			else
				negType = "Отрицательное";

			// Является ли число простым
			string isPrime = "Является ли простым: ";
			if (IsPrime(number))
				isPrime = isPrime + "да";
			else
				isPrime = isPrime + "нет";

			// Делится ли на 2, 5, 3, 6, 9 без остатка
			string del2 = "Делится на 2: ";
			string del5 = "Делится на 5: ";
			string del3 = "Делится на 3: ";
			string del6 = "Делится на 6: ";
			string del9 = "Делится на 9: ";

			if (number % 2 == 0)
				del2 = del2 + "да";
			else
				del2 = del2 + "нет";

			if (number % 5 == 0)
				del5 = del5 + "да";
			else
				del5 = del5 + "нет";

			if (number % 3 == 0)
				del3 = del3 + "да";
			else
				del3 = del3 + "нет";

			if (number % 6 == 0)
				del6 = del6 + "да";
			else
				del6 = del6 + "нет";

			if (number % 9 == 0)
				del9 = del9 + "да";
			else
				del9 = del9 + "нет";

			infoBox.Text = negType + "\n" + isPrime + "\n" + del2 + "\n" + del5 + "\n" + del3 + "\n" + del6 + "\n" + del9;


		}

		// Является ли число простым
		private bool IsPrime(int number)
		{
			for (int i = 2; i < number; i++)
			{
				if (number % i == 0)
					return false;
			}
			return true;
		}
	}
}
