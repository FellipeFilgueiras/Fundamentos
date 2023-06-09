namespace ConversaoTipos;
class Program
{
    static void Main(string[] args)
    {
        decimal preco = 29.90m;

        int preco2 = (int) preco;
        Console.WriteLine($"Preço convertido para int: {preco2}");

        string preco3 = preco.ToString();
        Console.WriteLine($"Preço convertido para string: {preco3}");

        string resposta = "121";

        int resposta2 = int.Parse(resposta);
        Console.WriteLine($"Resposta convertida para int: {resposta2}");

        decimal resposta3 = int.Parse(resposta);
        Console.WriteLine($"Resposta convertida para decimal: {resposta3}");

        // Existe uma classe chamada "Convert" que é usada para as conversões de tipos.

        decimal taxa = 14.5m;

        int taxaInt = Convert.ToInt32(taxa);
        Console.WriteLine($"Taxa convertida para int: {taxaInt}");

        string taxaString = Convert.ToString(taxa);
        Console.WriteLine($"Taxa convertida para string: {taxaString}");

    }
}
