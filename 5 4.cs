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

namespace Task4
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

		private double creditSum = 0; // Сумма кредита
		private List<double> payments = new List<double>(); // История платежей

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (summaBox.Text == "" || paymentBox.Text == "")
			{
				MessageBox.Show("Заполните все значения", "Учёт платежей", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}

			// После первого ввода отключаем редактирование сумму кредита
			if (creditSum == 0)
			{
				creditSum = double.Parse(summaBox.Text);
				summaBox.IsEnabled = false;
			}

			AddPayment(double.Parse(paymentBox.Text));
			paymentBox.Text = "";
		}

		private void AddPayment(double paySum)
		{
			payments.Add(paySum);

			// Сколько выплачено всего: суммируем все платежи
			double totalPayed = payments.Sum();

			// Задолженность
			double debt;
			if (creditSum > totalPayed)
				debt = creditSum - totalPayed;
			else
				debt = 0;

			// Переплата
			double overpayment;
			if (totalPayed > creditSum)
				overpayment = totalPayed - creditSum;
			else
				overpayment = 0;

			// Состояние кредита
			string txt;
			if (debt <= 0)
				txt = "Долг отсутсвует";
			else
				txt = "Есть долг";

			MessageBox.Show("Cумма задолженности: " + debt + "; Сумма переплаты: " + overpayment + "; Долг: " + txt);
		}
	}
}