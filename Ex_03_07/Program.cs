using Ex_03_07.Modules;
namespace Ex_03_07;

static class Program
{
    static void Main(string[] args)
    {
        Item item = new();

        Console.Write("商品番号を入力してください->");
        item.ItemNo = int.Parse(Console.ReadLine() ?? "");
        Console.Write("商品名を入力してください->");
        item.ItemName = Console.ReadLine() ?? "";
        Console.Write("単価を入力してください->");
        item.Price = int.Parse(Console.ReadLine() ?? "");

        item.Print();
    }
}
