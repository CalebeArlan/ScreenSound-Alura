using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace Atividades;
public class Atividades
{
	public static void A02Exe008()
	{
		int notaMedia = 0;
		List<string> linguagensDeProgramacao = new List<string>();
		linguagensDeProgramacao.Add("C#");
		linguagensDeProgramacao.Add("Java");
		linguagensDeProgramacao.Add("Javascript");

		Console.WriteLine("****** LISTA DE LANGS *******");

		foreach(string lang in linguagensDeProgramacao)
		{
			Console.WriteLine($"{linguagensDeProgramacao.IndexOf(lang)} - {lang}");
		}
		Console.WriteLine("Digite o código da linguagem que deseja avaliar: ");
		int escolha = int.Parse(Console.ReadLine());

		Console.WriteLine($"Digite uma nota para a linguagem de programação {linguagensDeProgramacao[escolha]}: ");
		notaMedia = Convert.ToInt32(Console.ReadLine());
		if(notaMedia >= 5)
		{
			Console.WriteLine("Nota suficiente para aprovação.");
		}
		else { Console.WriteLine("Linguagem reprovada."); }
	}

	public static void A02Exe009()
	{
		int numeroAleatorio = RandomNumberGenerator.GetInt32(100);
		Console.Write("Adivinhe o número que estou pensando...\nSeu chute: ");
		int numero = Convert.ToInt32(Console.ReadLine());
		while (true)
		{
			if(numero < numeroAleatorio)
			{
				Console.WriteLine("O número que estou pensando é maior que esse..\nFaça uma nova tentativa: ");
				numero = Convert.ToInt32(Console.ReadLine());
			}
			else if(numero > numeroAleatorio)
			{
				Console.WriteLine("O número que estou pensando é menor que esse..\nFaça uma nova tentativa: ");
				numero = Convert.ToInt32(Console.ReadLine());

			}
			else if(numero == numeroAleatorio)
			{
				Console.WriteLine("Isso! Você acertou! Era esse número mesmo!");
				break;
			}

		}
	}

	public static void A03Exe007q01()
	{
		float numero01, numero02, adicao, subtracao, divisao, multiplicacao;
		Console.Write("Digite o primeiro número a ser calculado: ");
		numero01 = float.Parse(Console.ReadLine());

		Console.Write("Digite o segundo número a ser calculado: ");
		numero02 = float.Parse(Console.ReadLine());

		adicao = numero01 + numero02;
		subtracao = numero02 - numero01;
		divisao = numero01 / numero02;
		multiplicacao = numero01 * numero02;
		Console.WriteLine($"Soma dos números = {adicao}\nDiferença dos números = {subtracao}\nProduto dos números = {multiplicacao}\nQuociente dos números = {divisao}");
	}
	public static void A03Exe007q02y03()
	{
		List<string> minhasBandas = new List<string> { "Skillet", "Fireflight", "O Maior Clichê do Mundo", "Alva" };

		for(int i = 0; i < minhasBandas.Count; i++)
		{
			Console.WriteLine($"Banda - {minhasBandas[i]}");
		}
	}
	public static void A03Exe007q04()
	{
		List<int> listaNumerosInteiros = new List<int>();
		Console.WriteLine("Digite 10 números inteiros para fazermos um somatório.");
		int somatorio = 0,numeroDigitado = 0;
		for(int i = 1; i != 10 + 1;  i++)
		{
			Console.Write($"Digite o {i}° número: ");
			numeroDigitado = Int32.Parse(Console.ReadLine());
			listaNumerosInteiros.Add(numeroDigitado);

		}
		foreach(int numero in listaNumerosInteiros)
		{
			somatorio += numero;
		}
		Console.WriteLine("O somatório dos dez números foi de: " + somatorio);
	}
	public static void A03Exe008()
	{
		List<int> listaNumerosInteiros = new List<int>();
		Console.WriteLine("Digite 10 números inteiros para adicionar na lista.");
		int numeroDigitado = 0;
		for (int i = 1; i != 10 + 1; i++)
		{
			Console.Write($"Digite o {i}° número: ");
			numeroDigitado = Int32.Parse(Console.ReadLine());
			listaNumerosInteiros.Add(numeroDigitado);

		}
		Console.WriteLine("********* Mostrando com Foreach *********");
		foreach(int numero in listaNumerosInteiros)
		{
			if(numero % 2 == 0)
			{
				Console.WriteLine(numero);
			}
		}
		Console.WriteLine("********* Mostrando com Foreach *********");
		for (int i = 0; i < listaNumerosInteiros.Count; i++)
		{
			if (listaNumerosInteiros[i] % 2 == 0)
			{
				Console.WriteLine(listaNumerosInteiros[i]);
			}
		}

	}


}
