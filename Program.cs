using System;

namespace TolvOpgaverProve
{
	class Program
	{
		// opgave 1
		static void opgave_1()
		{
			string[] maaneder = {
				"Januar",
				"Febuar",
				"Marts",
				"April",
				"Maj",
				"Juni",
				"Juli",
				"August",
				"September",
				"Oktober",
				"November",
				"December"
			};
			int input = 0;
			while (true) {
			Console.Clear();
			Console.WriteLine("Hvis du skriver et nummer mellem 1-12 returnere programmet en maaned");
			Console.WriteLine();
			Console.WriteLine("Skriv et nummer mellem 1 og 12");
				try {
					input = Convert.ToInt32(Console.ReadLine());
				}
				catch (Exception) {
					Console.Clear();
					Console.WriteLine("Det er ikke et tal");
					Console.ReadLine();
				}
				if (input >= 1 && input <= 12) {
					break;
				}
				else {
					Console.Clear();
					Console.WriteLine("Det er ikke 1-12");
					Console.ReadLine();
				}
			}
			Console.Clear();
			Console.WriteLine("Returneret maaned");
			Console.WriteLine($"{input} => {maaneder[input-1]}");
			Console.ReadLine();
		}
		static void Main(string[] args)
		{
			while (true)
			{
				// opgave navne
				string[] opgaver = {
					"Måneder, korresponderende navn og tal",
					"Input fra bruger",
					"Check fpr type",
					"Alarm",
					"CenterChar",
					"Beregn udtryk",
					"SkjulCifre",
					"Symmetri",
					"Isogram",
					"Haeveautomat",
					"Smooth sentence",
					"Integer til Binaer byte"
				};

				int n = 0;
				Console.WriteLine("Velg en opgave");
				Console.WriteLine();
				foreach (string o in opgaver)
				{
					n++;
					Console.WriteLine($"{n}. {o}");
				}
				Console.WriteLine("L = Luk program");

				int menu = 0;
				string stringMenu = Console.ReadLine().ToUpper();
				if (stringMenu == "L")
				{
					return;
				}
				else
				{
					try {
						menu = Convert.ToInt32(stringMenu); }
					catch (Exception) {
						Console.Clear();
						Console.WriteLine("Det er ikke gyldigt input");
						Console.ReadLine(); }
				}

				switch (menu)
				{
					case 1: // opgave 1
						opgave_1();
						break;
				}
			}
		}
	}
}
