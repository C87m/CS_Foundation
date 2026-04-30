using Ex_03_08.Modules;
namespace Ex_03_08;

static class Program
{
    static void Main(string[] args)
    {
        NetAccount ac = new();

        Console.Write("口座番号を入力してください->");
        ac.AccountNo = Console.ReadLine();
        Console.Write("口座名義を入力してください->");
        ac.AccountName = Console.ReadLine();
        Console.Write("残高を入力してください->");
        ac.Balance = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("ポイントを入力してください->");
        ac.Point = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"口座番号：{ac.AccountNo} 口座名義：{ac.AccountName} 残高：{ac.Balance} ポイント：{ac.Point}");
    }
}
