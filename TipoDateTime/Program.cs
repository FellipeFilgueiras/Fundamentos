namespace TipoDateTime;
class Program
{
    static void Main(string[] args)
    {
        var hoje = DateTime.Today;
        var agora = DateTime.Now;
        var data1 = new DateTime(2023, 06, 06);
        var data2 = new DateTime(2023, 06, 06, 16, 20, 34);
        var data3 = DateTime.Parse("23/10/2023 13:57:30");

        Console.WriteLine(hoje);
        Console.WriteLine(agora);
        Console.WriteLine(data1);
        Console.WriteLine(data2);
        Console.WriteLine(data3);
        Console.WriteLine(data3.Day);
        Console.WriteLine(data3.Month);
        Console.WriteLine(data3.Year);
        Console.WriteLine(data3.Hour);
        Console.WriteLine(data3.Minute);
        Console.WriteLine(data3.Second);
        Console.WriteLine(data3.AddDays(2));
        Console.WriteLine(data3.AddMonths(-2));
        Console.WriteLine(data3.ToLongDateString());
        Console.WriteLine(data3.ToShortDateString());
        Console.WriteLine(data3.ToLongTimeString());
        Console.WriteLine(data3.ToShortTimeString());
        
    }
}
