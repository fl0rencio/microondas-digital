
using Microondas;

Console.WriteLine("Selecione a opção desejada:");
Console.WriteLine("1- Início rápido");
Console.WriteLine("2- Definir tempo e potência de aquecimento");

int.TryParse(Console.ReadLine(), out int opcaoDesejada);
if (opcaoDesejada == 1)
{
	Microwave.InicioRapido();
}
else if (opcaoDesejada == 2)
{
	Console.WriteLine("Digite o tempo desejado:");
	int.TryParse(Console.ReadLine(), out int tempo);	

	while (tempo < 1 || tempo > 120)
	{
		Microwave.ValidarTempo();
		int.TryParse(Console.ReadLine(), out int tempoValido);
		Microwave.Tempo = tempoValido;
		Microwave.ValidarTempo();
	}

	Console.WriteLine();
	Console.WriteLine("Digite a potência desejada:");
	int.TryParse(Console.ReadLine(), out int potencia);	

	while (potencia < 1 || potencia > 10)
	{
		Microwave.ValidarPotencia();
		int.TryParse(Console.ReadLine(), out int potenciaValida);
		Microwave.Potencia = potenciaValida;
		Microwave.ValidarPotencia();
	}
	
	new Microwave(tempo, potencia);

	Console.WriteLine("Digite OK ou tecle ENTER para iniciar o aquecimento:");
	string iniciarAquecimento = Console.ReadLine();
	if (string.IsNullOrWhiteSpace(iniciarAquecimento) || iniciarAquecimento.Equals("ok", StringComparison.OrdinalIgnoreCase))
	{
		Microwave.IniciarAquecimento();
	}
}

Console.WriteLine("3- Adiciodar 30 segundos no aquecimento");
int.TryParse(Console.ReadLine(), out int adicionar30Seg);
if (adicionar30Seg == 3)
{
	Microwave.Adicionar30Segundos();
}