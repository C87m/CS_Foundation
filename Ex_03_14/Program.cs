namespace Ex_03_14;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値1を入力してください->");
        int num1 = int.Parse(Console.ReadLine()  ?? "0");
        Console.Write("値2を入力してください->");
        int num2 = int.Parse(Console.ReadLine()  ?? "0");

        Console.WriteLine($"加算： {num1.Add(num2)}");
        Console.WriteLine($"平均： {num1.Average(num2)}");
        
    }
}
