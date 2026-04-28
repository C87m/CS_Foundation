using System.Globalization;

namespace Ex_02_04;

static class Program
{
    static void Main(string[] args)
    {
        var nums = new double[3];

        for(int i=0; i<3; i++)
        {
            Console.Write($"数値{i+1}を入力してください->");
            nums[i] = double.Parse(Console.ReadLine() ?? "0"); // nullだったときは0を入れる
            // 数値に変換できないときの処理を入れたい
        }

        Console.WriteLine("入力結果");

        for(int i=0; i<3; i++)
        {
            Console.WriteLine($"数値{i+1}:{nums[i]}");
        }
    }
}
