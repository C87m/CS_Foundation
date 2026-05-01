namespace Ex_03_15;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値1を入力してください->");
        int num1 = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("値2を入力してください->");
        int num2 = int.Parse(Console.ReadLine() ?? "1");

        try
        {
            Calculator calc = new();
            Console.WriteLine($"値1 / 値2 = {calc.Div(num1, num2)}");
        }
        catch
        {
            Console.WriteLine("例外：Attempted to divide by zero.");
        }
    }
}
