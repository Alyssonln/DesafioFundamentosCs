namespace DesafioFundamentosC_.Desafios.Exercicio01;

public class Exercicio01
{
    public static void Executar()
    {
        Console.Write("Qual o seu nome?");
        string? nome = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome não informado!");
        }
        else
        {
            Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
        }
    }
}