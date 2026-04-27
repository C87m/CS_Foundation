namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        var a = 10;
        Console.WriteLine($"a < 10  -> {a < 10}");
        Console.WriteLine($"a < 20  -> {a < 20}");
        Console.WriteLine($"a <  0  -> {a < 0}");
        Console.WriteLine($"a > 10  -> {a > 10}");
        Console.WriteLine($"a > 20  -> {a > 20}");
        Console.WriteLine($"a >  0  -> {a > 0}");
        Console.WriteLine($"a <= 10 -> {a <= 10}");
        Console.WriteLine($"a <= 20 -> {a <= 20}");
        Console.WriteLine($"a <=  0 -> {a <= 0}");
        Console.WriteLine($"a >= 10 -> {a >= 10}");
        Console.WriteLine($"a >= 20 -> {a >= 20}");
        Console.WriteLine($"a >=  0 -> {a >= 0}");


    }
}