namespace DesafioFundamentosC_.Desafios.Exercicio03;

public class Exercicio03
{
    public static void Executar()
    {
        Console.Write("Primeiro número: ");
        string? primeiro  = Console.ReadLine();
        Console.Write("Segundo número: ");
        string? segundo = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(primeiro) || string.IsNullOrWhiteSpace(segundo))
        {
            Console.WriteLine("Informe os numeros!");
            return;
        }

        double primeiroNumero = Convert.ToDouble(primeiro);
        double segundoNumero = Convert.ToDouble(segundo);

        Console.WriteLine("Operação: soma / subtração / multiplicação / divisão / média ");
        string? operacao = Console.ReadLine();

        double resultado;

        switch (operacao)
        {
            case "soma":
                resultado = primeiroNumero + segundoNumero;
                break;
            case "subtração":
                resultado = primeiroNumero - segundoNumero;
                break;
            case "multiplicação":
                resultado = primeiroNumero * segundoNumero;
                break;
            case "divisão":
                if (primeiroNumero == 0 || segundoNumero == 0)
                {
                    Console.WriteLine("Não é possível dividir por zero!");
                    return;
                }
                resultado = primeiroNumero / segundoNumero;
                break;
            case "média":
                resultado = (primeiroNumero + segundoNumero) / 2;
                break;
            default:
                Console.WriteLine("Opção inválida!");
                return;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }
}