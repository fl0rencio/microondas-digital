namespace Microondas
{
	internal class Microwave
	{
		public static int Tempo { get; set; }
		public static int Potencia { get; set; }

		public Microwave(int tempo, int potencia)
		{
			Tempo = tempo;
			Potencia = potencia;
		}

		public static void ValidarTempo()
		{
			if (Tempo < 1 || Tempo > 120)
			{
				Console.WriteLine("O tempo deve ser entre 1 e 120.");
				Console.WriteLine("Digite o tempo desejado:");
			}
		}

		public static void ValidarPotencia()
		{
			if (Potencia == 0)
			{
				Potencia = 10;
				Console.WriteLine(Potencia);
			}
			else if (Potencia < 1 || Potencia > 10)
			{
				Console.WriteLine("A potência deve ser de 1 a 10, caso não seja informada a potência será de 10.");
				Console.WriteLine("Digite a potência desejada:");
			}
		}

		public static void InicioRapido()
		{
			Tempo = 30;
			Potencia = 10;
			Console.WriteLine($"Tempo: {Tempo} | Potência: {Potencia}");
			DefinirModoAquecimento(Tempo, Potencia);
		}

		public static void IniciarAquecimento()
		{
			DefinirModoAquecimento(Tempo, Potencia);
		}

		public static void Adicionar30Segundos()
		{
			DefinirModoAquecimento(30, Potencia);
		}

		private static void DefinirModoAquecimento(int tempo, int potencia)
		{
			var modoAquecimento = string.Empty;

			for (int i = 1; i <= tempo; i++)
			{
				for (int j = 1; j <= potencia; j++)
				{
					modoAquecimento += ".";
				}

				if (potencia > 1)
					modoAquecimento += " ";

			}

			if (potencia > 1)
			{
				var processamento = modoAquecimento.Split(" ");

				foreach (var item in processamento)
				{
					Thread.Sleep(1000);
					Console.Write($"{item} ");
				}
			}
			else
			{
				for (int i = 1; i <= tempo; i++)
				{
					Thread.Sleep(1000);
					Console.Write(".");
				}
			}

			Console.Write(" Aquecimento concluído");
			Console.WriteLine();
		}
	}
}