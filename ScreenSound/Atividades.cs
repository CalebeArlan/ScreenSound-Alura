namespace Atividades;
public class Atividades
{
	public static void Exe008()
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
}
