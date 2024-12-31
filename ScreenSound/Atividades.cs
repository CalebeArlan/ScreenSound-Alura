using System.ComponentModel.Design;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Xml;

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

	public static void MediaAlunoDicionarios()
	{
		//Aula 04 Exercício 08 Atividade 01
		//Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
		Dictionary<string, List<double>> AlunosNotas = new Dictionary<string, List<double>>();

		AlunosNotas.Add("Lucas", new List<double> { 1, 2, 3, 4, 5, 6, });
		AlunosNotas.Add("Ana Rita", new List<double> {9,3,5,9,8,10 });
		AlunosNotas.Add("Thayane", new List<double> { 10, 4, 5, 9, 3, 10 });

		for(int i = 0; i < AlunosNotas.Keys.Count; i++)
		{
			double media;
			Console.WriteLine("Notas do(a) " + AlunosNotas.Keys.ElementAt(i));

			foreach(List<double> listaNotas in AlunosNotas.Values)
			{
				media = listaNotas.Average();
				Console.WriteLine($"A média deste(a) aluno foi: {media}");
			}
		}
    }
	static Dictionary<string, int> EstoqueProdutos = new Dictionary<string, int>();
	static Dictionary<string, string> UsuariosSenhas = new Dictionary<string, string>();
	public static void GerenciaEstoque()
	{
		static void Login()
		{
			UsuariosSenhas.Add("User", "123");
			UsuariosSenhas.Add("Admin", "Admin");
			UsuariosSenhas.Add("Calebe", "SenhaMuitoForte");

			string usuario, senha;
			Console.WriteLine("******");
			Console.WriteLine("Login");
			Console.WriteLine("******\n\n");
			Console.Write("Digite seu nome de usuário: ");
			usuario = Console.ReadLine()!;
			Console.WriteLine("Digite sua senha: ");
			senha = Console.ReadLine()!;
			if (ValidaLogin(usuario, senha))
			{
				Menu();
			}
			else
			{
				Console.WriteLine("Usuário e/ou senha inválidos!");
				Login();
			}
		}
		static bool ValidaLogin(string usuario, string senha)
		{
			if (UsuariosSenhas[usuario].Contains(senha))
			{
				return true;
			}
			return false;
		}

		static void Menu()
		{
			Console.Clear();
			Console.WriteLine(@"
=========================================================================  

  __   _   ,   -/- _,_ ,_      __/   _      _   ,   -/- _,_ __        _ 
_(_/__(/__/_)__/__(_/_/ (_   _(_/(__(/_   _(/__/_)__/__(_/_(_/__(_/__(/_
 _/_                                                       _/           
(/                                                         /)           
                                                           `            
=========================================================================
");
			Console.Write("1 - Cadastrar Novo Produto\n2 - Alterar Quantidade de Produto Existente\n3 - Consultar Quantidade por Nome\n0 - Sair\nSua escolha: ");
			string opcao = Console.ReadLine();
			switch (opcao)
			{
				case "1": CadastrarProduto();
					break;
				case "2": AlterarQuantidade();
					break;
				case "3": ExibirQuantidade();
					break;
				case "4": Console.WriteLine("Até mais!");
					break;
				default: Console.WriteLine("Digite uma opção válida!");
					break;
			}
		}

		static void CadastrarProduto()
		{
			string nome;
			int quantidade;
			Console.Write("Digite o nome do novo produto: ");
			nome = Console.ReadLine()!;
			Console.Write("Digite a quantidade de itens no estoque para este produto: ");
			quantidade = int.Parse(Console.ReadLine()!);

			if (IsItemCadastrado(nome))
			{
				Console.WriteLine("Esse produto já está cadastrado!");
			}
			else
			{
				EstoqueProdutos.Add(nome, quantidade);
				Console.WriteLine($"O produto {nome} com a quantidade {quantidade} foi cadatrado com sucesso!");
			}
			Console.WriteLine("Digite qualquer tecla para continuar");
			Console.ReadKey();
			Menu();
		}
		static void AlterarQuantidade()
		{
			string nome;
			int quantidade;
			Console.Write("Digite o nome do produto a ser alterado a quantidade: ");
			nome = Console.ReadLine()!;
			Console.Write("Digite a nova quantidade vigente do produto: ");
			quantidade = int.Parse(Console.ReadLine()!);

			if (IsItemCadastrado(nome))
			{
				EstoqueProdutos[nome] = quantidade;
				Console.WriteLine($"Quantidade para o item {nome} foi alterada com sucesso!");
			}
			else
			{
				Console.WriteLine("Nome incorreto ou este produto não está cadastrado.");
			}
			Console.WriteLine("Digite qualquer tecla para continuar");
			Console.ReadKey();
			Menu();
		}
		static void ExibirQuantidade()
		{
			string nome;
			Console.Write("Digite o nome do produto que deseja buscar: ");
			nome = Console.ReadLine()!;
			if(IsItemCadastrado(nome))
			{
				foreach (string item in EstoqueProdutos.Keys)
				{
					if (item == nome)
					{
						Console.WriteLine($"O produto {nome} tem {EstoqueProdutos[nome]} em estoque.");
					}
				}
			}
			else
			{
				Console.WriteLine("Produto não encontrado. Verifique se digitou corretamente.");
			}
			Console.WriteLine("Digite qualquer tecla para continuar");
			Console.ReadKey();
			Menu();
		}
		static bool IsItemCadastrado(string nomeProduto)
		{
			foreach (string item in EstoqueProdutos.Keys)
			{
				if (item == nomeProduto)
				{
					return true;
				}
			}
			return false;
		}
		Login();
	}

}
