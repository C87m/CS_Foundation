using System.Net.ServerSentEvents;
using Ex_04_01_Lib;

namespace Ex_04_01;

static class Program
{
    static void Main(string[] args)
    {
        Item item = new();
        Console.Write("商品番号を入力してください->");
        item.ItemNo = int.Parse(Console.ReadLine());
        Console.Write("商品名を入力してください->");
        item.ItemName = Console.ReadLine();
        Console.Write("単価を入力してください->");
        item.Price = int.Parse(Console.ReadLine());

        Console.WriteLine("結果");

        Console.WriteLine($"商品番号 = {item.ItemNo}");
        Console.WriteLine($"商品名 = {item.ItemName}");
        Console.WriteLine($"単価 = {item.Price}");
    }
}
