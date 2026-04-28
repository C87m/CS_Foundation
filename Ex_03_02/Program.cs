namespace Ex_03_02;

static class Program
{
    static void Main(string[] args)
    {
        Item item = new();

        Console.Write("商品番号を入力してください->");
        item.itemNo = int.Parse(Console.ReadLine() ?? "");
        Console.Write("商品名を入力してください->");
        item.itemName = Console.ReadLine() ?? "";
        Console.Write("単価を入力してください->");
        item.price = int.Parse(Console.ReadLine() ?? "");

        item.Print(item);
    }
}
