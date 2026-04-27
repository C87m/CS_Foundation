using System.Globalization;

namespace Ex_02_03;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        string s = Console.ReadLine() ?? "";
        double num = double.Parse(s);

        Console.WriteLine($"5を加算した結果は{num+5}です");
        Console.WriteLine($"5を減算した結果は{num-5}です");
    }
}
