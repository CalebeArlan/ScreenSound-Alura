﻿using Atividades;
string mensagemDeBoasVindas = "Bem vindo ao ScreenSound!";
//List<string> listaDasBandas = new List<string> {"Skillet","Fireflight","Calypso"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 9, 10, 5 });
bandasRegistradas.Add("The Beatles", new List<int>());
void ExibirLogo()
{
	Console.WriteLine(@"


░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
	Console.WriteLine(mensagemDeBoasVindas);

}

void ExibirOpcoesDoMenu()
{
	ExibirLogo();
	Console.WriteLine("\nDigite 1 para registrar uma banda;");
	Console.WriteLine("Digite 2 para mostrar todas as bandas");
	Console.WriteLine("Digite 3 para avaliar uma banda");
	Console.WriteLine("Digite 4 para exibir a média de uma banda");
	Console.WriteLine("Digite -1 para sair");

	Console.Write("\nDigite a sua opção: ");
	string opcaoEscolhida = Console.ReadLine()!;
	int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

	switch (opcaoEscolhidaNumerica)
	{
		case 1: RegistrarBanda();
			break;
		case 2: MostrarBandasRegistradas();
			break;
		case 3: AvaliarUmaBanda();
			break;
		case 4: Console.WriteLine("Você digitu a opção " + opcaoEscolhida);
			break;
		case -1: Console.WriteLine("Tchau, tchau! :)");
			break;
		default: Console.WriteLine("Opção inválida!");
			break;
	}
}

void RegistrarBanda()
{
	Console.Clear();
	ExibirTituloDaOpcao("Registro das Bandas");
	Console.Write("Digite o nome da banda que deseja registrar: ");
	string nomeDaBanda = Console.ReadLine()!;
	bandasRegistradas.Add(nomeDaBanda, new List<int>());
	Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
	Thread.Sleep(2000);
	Console.Clear();
	ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
	Console.Clear();
	ExibirTituloDaOpcao("Exibindo Todas as Bandas Registradas");
/*	for (int i = 0; i < listaDasBandas.Count; i++)
	{
		Console.WriteLine($"Banda: {listaDasBandas[i]}");
	}*/
	foreach(string banda in bandasRegistradas.Keys)
	{
		Console.WriteLine($"Banda: {banda}");
	}
	Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
	Console.ReadKey();
	Console.Clear();
	ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
	int quantidadeDeLetras = titulo.Length;
	string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
	Console.WriteLine(asteriscos);
	Console.WriteLine(titulo);
	Console.WriteLine(asteriscos + "\n");
}
void AvaliarUmaBanda()
{
	Console.Clear();
	ExibirTituloDaOpcao("Avaliar Banda");
	Console.Write("Digite o nome da banda que deseja avaliar? ");
	string nomeDaBanda = Console.ReadLine()!;
	if (bandasRegistradas.ContainsKey(nomeDaBanda))
	{
		Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
		int nota = int.Parse(Console.ReadLine()!);
		bandasRegistradas[nomeDaBanda].Add(nota);
		Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
		Thread.Sleep(2000);
		Console.Clear();
		ExibirOpcoesDoMenu();
	}
	else
	{
		Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
		Console.WriteLine("Digite uma tecla para voltar ao menu principal");
		Console.ReadKey();
		Console.Clear();
		ExibirOpcoesDoMenu();
	}
}
Atividades.Atividades.MediaVendaCarros();
//ExibirOpcoesDoMenu();


