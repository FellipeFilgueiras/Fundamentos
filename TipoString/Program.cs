namespace TipoString;
class Program
{
    static void Main(string[] args)
    {
        // Tipo string possui diversos métodos para nos auxiliar no uso de textos.

        var nome = "Fellipe";
        var sobrenome = "Filgueiras";
        var completo = $"{ nome } { sobrenome }";

        Console.WriteLine(completo);
        Console.WriteLine(completo.ToUpper());
        Console.WriteLine(completo.ToLower());
        Console.WriteLine(completo.Substring(4));
        Console.WriteLine(completo.Substring(4, 5));
        Console.WriteLine(completo.Contains('o'));
        Console.WriteLine(completo.Contains("Fe"));
        Console.WriteLine(completo.StartsWith("F"));
        Console.WriteLine(completo.EndsWith("li"));
        Console.WriteLine(completo.IndexOf("e"));
        Console.WriteLine(completo.LastIndexOf("l"));
    }
}
