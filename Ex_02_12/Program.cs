using System.Globalization;

namespace Ex_02_12;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値を入力してください->");

        double num = double.Parse(Console.ReadLine() ?? "");

        Console.WriteLine(Mul3(num));

        double Mul3(double num)
        {
            return num * 3;
        }

    }

}
