namespace Repeticao;
class Program
{
    static void Main(string[] args)
    {

        // WHILE (Primeiro verifica, depois faz)
        Console.WriteLine("WHILE");
        int quantidade = 10;
        int demanda = 10;
        while (quantidade < demanda)
        {
            Console.WriteLine($"Produzindo camisa { quantidade }...");
            quantidade ++;
        }

        // DO-WHILE (Primeiro faz, depois verifica)
        quantidade = 10;
        Console.WriteLine();
        Console.WriteLine("DO WHILE");
        do
        {
            Console.WriteLine($"Produzindo calça { quantidade }...");
            quantidade ++;
        } while (quantidade < demanda);

        Console.WriteLine();
        Console.WriteLine("FOR");
        for(int i = 1; i <= demanda; i++)
        {
            Console.WriteLine($"Produzindo meia { i }");
        }

        // FOREACH (Percorrer listas e arrays)
        Console.WriteLine();
        Console.WriteLine("FOREACH");
        string[] nomes = { "Jose", "Maria", "João", "Carmem", "Paulo", "Joana" };
        foreach(var nome in nomes)
        {
            Console.WriteLine($"Nome: { nome }");
        }

    }
}
