using System.Runtime.CompilerServices;

namespace Ex_03_16;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値1を入力してください->");
        int num1 = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("値1を入力してください->");
        int num2 = int.Parse(Console.ReadLine() ?? "1");

        try
        {
            Calculator calc = new();
            Console.WriteLine($"値1 / 値2 = {calc.Div(num1, num2)}");
        }
        catch (InputParameterLessThanZeroException e)
        {
            //xに{num1}が入力されました。正の値を入力してください。
            Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("必ず実行");
        }
        Console.WriteLine("プログラム正常終了");

    }
}
