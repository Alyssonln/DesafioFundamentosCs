namespace DesafioFundamentosC_.Desafios.Exercicio04;

public class Exercicio04
{
    public static void Executar()
    {
        Console.Write("Contador de caracteres: ");
        string? contador = Console.ReadLine();

        if (string.IsNullOrEmpty(contador))
        {
            Console.WriteLine("Caractres: 0");
        }
        else
        {
            string tratandoContador = contador.Replace(" ", "").Trim();
            Console.WriteLine($"Caracteres: {tratandoContador.Length}");
        }
    }
}
