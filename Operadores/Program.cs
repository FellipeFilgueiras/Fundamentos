namespace Operadores;
class Program
{
    static void Main(string[] args)
    {
        
        // Operadores aritméticos
        var a = 10;
        var b = 2;

        Console.WriteLine($"Soma: { a + b }");
        Console.WriteLine($"Subtração: { a - b }");
        Console.WriteLine($"Multiplicação: { a * b }");
        Console.WriteLine($"Divisão: { a / b }");
        Console.WriteLine($"Resto da divisão: { a % b}");
        Console.WriteLine($"Potência: { Math.Pow(10, 2) }");
        Console.WriteLine($"Raiz quadrada: { Math.Sqrt(25) }");

        // Operadores de atribuição
        a += 2; //a = a + 2
        a -= 1; //a = a - 2
        a *= 2; //a = a * 2
        a /= 2; //a = a / 2
        a %= 2; //a = a % 2

        // Operadores de incremento e decremento
        var c = 5;
        var d = 5;
        Console.WriteLine($"Valor inicial de C: { c }");
        Console.WriteLine($"Valor inicial de D: { c }");
        Console.WriteLine($"Pré incremento: { ++c }"); // Acontece antes da execução do método.
        Console.WriteLine($"Pré decremento: { --d }"); // Acontece antes da execução do método.

        Console.WriteLine($"Pós incremento: { c++ }"); // Acontece depois da execução do método.
        Console.WriteLine($"Pós decremento: { d-- }"); // Acontece depois da execução do método.
        Console.WriteLine($"Valor atual de C: { c }");
        Console.WriteLine($"Valor atual de D: { d }");

        // Operadores de comparação
        var e = 10;
        var f = 20;
        Console.WriteLine($"Iguais: { e == f }");
        Console.WriteLine($"Diferentes: { e != f }");
        Console.WriteLine($"Maior: { e > f }");
        Console.WriteLine($"Maior ou igual: { e >= f }");
        Console.WriteLine($"Menor: { e < f }");
        Console.WriteLine($"Menor ou igual: { e <= f }");
        
        // Operadores lógicos
        var g = 11;
        var h = 12;

        Console.WriteLine($"Condição AND: { g > 10 && h < 10 }"); // Os dois lados devem ser verdadeiros para retornar true.
        Console.WriteLine($"Condição OR: { g > 10 || h < 10 }"); // Um dos lados devem ser verdadeiros para retornar true.

    }
}
