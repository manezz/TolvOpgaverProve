using System;
using System.Linq;
using System.Collections.Generic;

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
						break;
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
		static void opgave_3/*(SameType)*/(object a, object b)
		{
			bool bo;
			if (a.GetType() == (b.GetType())) {
				bo = true;
			}
			else {
				bo = false;
			}
			Console.WriteLine($"{a} & {b} => {bo}");
		}
		static void opgave_4/*(Alarm)*/(string p)
		{
			if (p.ToLower().Contains("bombe")) {
				Console.WriteLine($"{p} => Bombealarm - løb");
			}
			else {
				Console.WriteLine($"{p} => Falsk alarm - slap af");
			}
		}
		static void opgave_5(string p)
		{
			char[] array = p.ToCharArray();
			string mid;
			if (array.Length % 2 == 0) {
				mid = Convert.ToString(array[array.Length/2-1]);
				mid += Convert.ToString(array[array.Length/2]);
			}
			else {
				mid = Convert.ToString(array[array.Length/2]);
			}
			Console.WriteLine($"{p} => {mid}");
		}
		static void opgave_6/*(Beregn)*/(string p)
		{
			char[] array = p.ToCharArray();
			int b = Convert.ToInt32(array[0].ToString());
			for (int i = 0;i < array.Length; i++) {
				if (array[i].ToString() == "+") {
					b += Convert.ToInt32(array[i+1].ToString());
				}
				else if (array[i].ToString() == "-") {
					b -= Convert.ToInt32(array[i+1].ToString());
				}
				else if (array[i].ToString() == "*") {
					b *= Convert.ToInt32(array[i+1].ToString());
				}
				else if (array[i].ToString() == "/") {
					b /= Convert.ToInt32(array[i+1].ToString());
				}
			}
			Console.WriteLine($"{p} => {b}");
		}
		static void opgave_7/*SkjulCifre*/(string p)
		{
			char[] array = p.ToCharArray();
			string num = "";
			if (array.Length > 4)
			{
				for (int i = 0; i < array.Length-4; i++) {
					num += "#";
				}
				for (int i = array.Length-4; i < array.Length; i++) {
					num += array[i].ToString();
				}
			}
			else {
				foreach (char c in array) {
					num += c.ToString();
				}
			}
			Console.WriteLine($"{p} => {num}");
		}
		static void opgave_8(int p)
		{
			char[] array = p.ToString().ToCharArray();
			string mid = Convert.ToString(array[array.Length/2-1]);
			Array.Reverse(array);
			string mid2 = Convert.ToString(array[array.Length/2-1]);
			if (mid == mid2) {
				Console.WriteLine($"{p} => True");
			}
			else {
				Console.WriteLine($"{p} => False");
			}
		}
		static void opgave_9(string p)
		{
			List<char> chars = new List<char>();
			char[] array = p.ToLower().ToCharArray();
			foreach (char c in array) {
				if (chars.Contains(c)) {
					Console.WriteLine($"{p} => False");
					return;
				}
				else {
					chars.Add(c);
				}
			}
			Console.WriteLine($"{p} => True");
		}
		static void opgave_10(string p)
		{
			char[] array = p.ToCharArray();
			string s = "";
			int i = 0;
			if (array.Length == 4) {
				foreach (char c in array) {
					s += c.ToString();
				}
				try {
					i = Convert.ToInt32(s);
					Console.WriteLine($"{p} => True");
				}
				catch (Exception) {
					Console.WriteLine($"{p} => False");
				}
			}
			else {
				Console.WriteLine($"{p} => False");
			}
		}
		static void opgave_11(string p)
		{
			string[] stringArray = p.ToLower().Split(" ");
			for (int i = 0; i < stringArray.Length-1; i++) {
				char[] array = stringArray[i].ToCharArray();
				char[] array2 = stringArray[i+1].ToCharArray();
				if (array.Last().ToString() != array2.First().ToString()) {
					Console.WriteLine($"{p} => False");
					return;
				}
			}
			Console.WriteLine($"{p} => True");
		}
		static void opgave_12()
		{
			List<string> num = new List<string>();
			int number = 0;
			int number2 = 0;
			int conv = 1;
			void GetNumberFromUser()
			{
				Console.WriteLine("Skriv et heltal mellem 0 og 255");
            	number = Convert.ToInt32(Console.ReadLine());
            	number2 = number;
			}
			void ConvertIntReturnBinaryString()
			{
				while (number >= conv)
            	{
                	number -= conv;
                	conv += conv;
            	}
            	while (conv != 0)
            	{
                	if (number2 - conv >= 0)
                	{
                    	num.Add("1");
                    	number2 -= conv;
                    	if (conv == 1) { conv -= 1; }
                    	else { conv /= 2; }
             		}
                	else
                	{
                    	num.Add("0");
                    	if (conv == 1) { conv -= 1; }
                    	else { conv /= 2; }
                	}
            	}
			}
			void ShowResult()
			{
				num.ForEach(i => Console.Write(i));
			}

			GetNumberFromUser();
			ConvertIntReturnBinaryString();
			ShowResult();
		}
		static void Main(string[] args)
		{
			while (true)
			{
				string[] opgaver = {
					"Maaneder",
					"korresponderende navn og tal",
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
					
					case 5:
						Console.Clear();
						opgave_5("test");
						opgave_5("teste");
						opgave_5("midten");
						opgave_5("A");
						Console.ReadLine();
						break;

					case 6:
						Console.Clear();
						opgave_6("2+7+1+4");
						opgave_6("6/3+7+8");
						opgave_6("3*9-5-7");
						Console.ReadLine();
						break;

					case 7:
						Console.Clear();
						opgave_7("23421124531696");
						opgave_7("424215211696");
						opgave_7("352");
						opgave_7("");
						Console.ReadLine();
						break;

					case 8:
						Console.Clear();
						opgave_8(498167);
						opgave_8(88888888);
						opgave_8(77677);
						Console.ReadLine();
						break;
					
					case 9:
						Console.Clear();
						opgave_9("DingDong");
						opgave_9("Algoritme");
						opgave_9("PasSword");
						opgave_9("Beslutte");
						Console.ReadLine();
						break;
					
					case 10:
						Console.Clear();
						opgave_10("4631");
						opgave_10("79215");
						opgave_10("8134");
						opgave_10("a561");
						Console.ReadLine();
						break;

					case 11:
						Console.Clear();
						opgave_11("Marta appreciated deep perpendicular right trapezoids");
						opgave_11("Mine evner rækker rimeligt tilfreds stillende");
						opgave_11("Tellefonen ringer");
						Console.ReadLine();
						break;

					case 12:
						Console.Clear();
						opgave_12();
						Console.ReadLine();
						break;		
				}
			}
		}
	}
}
