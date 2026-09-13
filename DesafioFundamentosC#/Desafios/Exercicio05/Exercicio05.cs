namespace DesafioFundamentosC_.Desafios.Exercicio05;

public class Exercicio05
{
    public static void Executar()
    {
        Console.Write("Digite a placa: ");
        string? placa = Console.ReadLine();

        bool placaValida = ValidarPlaca(placa);
        Console.WriteLine($"A placa {placa?.ToUpper()} é {(placaValida ? "válida" : "inválida")}.");
    }

    private static bool ValidarPlaca(string? placa)
    {
        if (string.IsNullOrEmpty(placa) || placa.Length != 7)
        {
            return false;
        }

        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placa[i]))
            {
                return false;
            }
        }

        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(placa[i]))
            {
                return false;
            }
        }
        return true;
    }
}
