using System;

namespace TolvOpgaverProve
{
	class Program
	{
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
		
		static void opgave_2()
		{
			int[] tal = new int[5];
			double gennemsnit = 0;
			while (true) {
				Console.Clear();
				Console.WriteLine("Hvis du skrive 5 tal faar du gennemsnitsvaerdien"+
				"(tryk Enter for at fortsaette)");
				Console.WriteLine();
				for (int i = 0; i <= 4; i++) {
					while (true) {
						try {
							Console.Clear();
							Console.WriteLine($"Tal {i+1}/5");
							Console.WriteLine();
							Console.WriteLine("Skriv et tal");
							tal[i] = Convert.ToInt32(Console.ReadLine());
						}
						catch {
							Console.Clear();
							Console.WriteLine("Det er ikke et tal");
							Console.ReadLine();
						}
					}
				}
				break;
			}
			Console.Clear();
			Console.WriteLine("Vaerdier");
			foreach (int i in tal) {
				gennemsnit += i;
				Console.WriteLine(i);
			}
			gennemsnit /= 5;
			Console.WriteLine("Gennemsnitsvaerdi = {0:f2}", gennemsnit);
			Console.ReadLine();
		}
		static void opgave_3(object a, object b)
		{
			bool bo;
			if (a.GetType() == (b.GetType())) {
				bo = true;
			}
			else {
				bo = false;
			}
			Console.WriteLine($"{a} & {b} => {bo}");
			return;
		}
		static void opgave_4(string p)
		{
			if (p.ToLower().Contains("bombe")) {
				Console.WriteLine($"{p} => Bombealarm - løb");
			}
			else {
				Console.WriteLine($"{p} => Falsk alarm - slap af");
			}
		}
		static void Main(string[] args)
		{
			while (true)
			{
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
					case 1:
						opgave_1();
						break;

					case 2:
						opgave_2();
						break;
					
					case 3:
						Console.Clear();
						opgave_3("d", true);
						opgave_3(1, "c");
						opgave_3("h", "y");
						Console.ReadLine();
						break;
					
					case 4:
						Console.Clear();
						opgave_4("Der er en bombe");
						opgave_4("Tror du virkelig der er en bombe?");
						opgave_4("Pas paa, den springer i luftem");
						Console.ReadLine();
						break;
				}
			}
		}
	}
}
