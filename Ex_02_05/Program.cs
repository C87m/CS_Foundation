namespace Ex_02_05;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        int num = int.Parse(Console.ReadLine() ?? "");

        if (num % 2 == 0)
        {
            Console.WriteLine($"結果:{10*num}");
        }
        else
        {
            Console.WriteLine($"結果:{num}");
        }
    }
}
