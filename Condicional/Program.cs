namespace Condicional;
class Program
{
    static void Main(string[] args)
    {
        // IF - ELSE
        var idade = 17;
        var cadastrado = true;

        if (idade >= 18)
        {
            Console.WriteLine("Entrada VIP autorizada!");
        }
        else if (idade >= 16 && idade < 18)
        {
            Console.WriteLine("Entrada padrão autorizada!");
        }
        else
        {
            Console.WriteLine("Entrada não autorizada!");
        }

        if (idade > 18 || cadastrado)
        {
            Console.WriteLine("Acesso permitido!");
        }

        // Operador ternário (Condicao ? resposta verdadeira : resposta falsa)
        var mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade";
        Console.WriteLine(mensagem);

        // Switch case
        Console.WriteLine("Escolha uma das opções:");
        Console.WriteLine("1 - Saque\n2 - Depósito \n3 - Extrato");
        var opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                Console.WriteLine("Sacando R$100,00...");
                break;
            case "2":
                Console.WriteLine("Digite o valor do depósito: ");
                break;
            case "3":
                Console.WriteLine("Imprimindo extrato...");
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

    }
}
