using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
using Ex_03_09.Modules;
namespace Ex_03_09;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("口座番号を入力してください->");
        string accountNo = Console.ReadLine();
        Console.Write("口座名義を入力してください->");
        string accountName = Console.ReadLine();
        Console.Write("残高を入力してください->");
        int balance = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("ポイントを入力してください->");
        int point = int.Parse(Console.ReadLine() ?? "0");

        NetAccount user = new(accountNo, accountName, balance, point);

        user.Print();

        Console.WriteLine(user.ToString());

    }
}
