namespace Ex_02_06;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        double num = double.Parse(Console.ReadLine() ?? "");

        if (num % 4 == 0)
        {
            Console.WriteLine("4の倍数です。");
        }
        else
        {
            Console.WriteLine("4の倍数ではありません。");
        }
    }
}
