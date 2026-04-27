using System.Globalization;

namespace Ex_02_03;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        // 数値じゃなかった場合の処理を入れたいところ
        string s = Console.ReadLine() ?? "";
        double num = double.Parse(s);

        Console.WriteLine($"5を加算した結果は{num+5}です");
        Console.WriteLine($"5を減算した結果は{num-5}です");
    }
}
