using System.Globalization;

namespace DesafioFundamentosC_.Desafios.Exercicio06;

public class Exercicio06
{
    public static void Executar()
    {
        var cultura = new CultureInfo("pt-BR");
        DateTime agora = DateTime.Now;

        Console.WriteLine("Escolha o formato de exibição da data:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data (dd/MM/yyyy)");
        Console.WriteLine("3 - Apenas a hora (formato 24h)");
        Console.WriteLine("4 - Data com o mês por extenso");
        Console.Write("Opção: ");

        string? opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine(agora.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", cultura));
                break;

            case "2":
                Console.WriteLine(agora.ToString("dd/MM/yyyy"));
                break;

            case "3":
                Console.WriteLine(agora.ToString("HH:mm:ss"));
                break;

            case "4":
                Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy", cultura));
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
