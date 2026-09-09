namespace DesafioFundamentosC_.Desafios.Exercicio02;

public class Exercicio02
{
    public static void Executar()
    {
        Console.Write("Primeiro nome?");
        string? primeiroNome = Console.ReadLine();
        Console.Write("Sobrenome?");
        string? sobrenome = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(primeiroNome) && string.IsNullOrWhiteSpace(sobrenome))
        {
            Console.WriteLine("Você não digitou nome e sobrenome!");
        }
        else
        {
            Console.WriteLine($"Nome completo: {primeiroNome} {sobrenome}");
        }
    }
}
