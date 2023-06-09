namespace TipoArray;
class Program
{
    static void Main(string[] args)
    {
        // Declaração separado da atribuição (Tamanho escolhido no momento da declaração)
        int[] numeros = new int[3];
        numeros[0] = 1;
        numeros[1] = 2;
        numeros[2] = 3;
        Console.WriteLine($"Valor na posição 0: {numeros[0]}");
        Console.WriteLine($"Valor na posição 1: {numeros[1]}");
        Console.WriteLine($"Valor na posição 2: {numeros[2]}");

        // Declaração junto com atribuição
        string[] nomes = new string[3] { "Fellipe", "Filgueiras", "Souza" };
        Console.WriteLine($"Nome na posição 0: {nomes[0]}");
        Console.WriteLine($"Nome na posição 1: {nomes[1]}");
        Console.WriteLine($"Nome na posição 2: {nomes[2]}");

        // Declaração com o tamanho definido pelo número de elementos, maneira mais simples de declaração.
        double[] notas = { 5.6, 7.8, 4.7, 8.9 };
        Console.WriteLine($"Nota na posição 0: {notas[0]}");
        Console.WriteLine($"Nota na posição 1: {notas[1]}");
        Console.WriteLine($"Nota na posição 2: {notas[2]}");
        Console.WriteLine($"Nota na posição 3: {notas[3]}");

    }
}
