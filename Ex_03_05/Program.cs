namespace Ex_03_05;

static class Program
{
    static void Main(string[] args)
    {

        Console.Write("商品番号を入力してください->");
        int pitemNo = int.Parse(Console.ReadLine() ?? "");
        Console.Write("商品名を入力してください->");
        string pitemName = Console.ReadLine() ?? "";
        Console.Write("単価を入力してください->");
        int pprice = int.Parse(Console.ReadLine() ?? "");

        Item item = new(pitemNo, pitemName, pprice);

        item.Print();
    }
}
