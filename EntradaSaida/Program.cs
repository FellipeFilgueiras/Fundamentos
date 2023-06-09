
namespace EntradaSaida
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Escreva o seu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine($"Bem vindo-a {nome}!");
        }
    }
    
}
