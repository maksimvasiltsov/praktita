using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите количество клиентов: ");
			string str = Console.ReadLine();
			int n = int.Parse(str);
			int variants = Factorial(n);
			Console.WriteLine("Количество возможных маршрутов доставки товара: " + variants);

			Console.WriteLine();
			Console.WriteLine("Для выхода нажмите любую клавишу");
			Console.ReadLine();
		}

		private static int Factorial(int a)
		{
			if (a == 0)
				return 1;
			return a * Factorial(a - 1);
		}
	}
}