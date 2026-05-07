namespace Ex_04_04;

static class Program
{
    static void Main(string[] args)
    {
        var items = new Dictionary<int, Item>();
        items.Add(101, new Item(101, "水性ボールペン(黒)", 150));
        items.Add(102, new Item(102, "油性ボールペン(黒)", 100));
        items.Add(103, new Item(103, "鉛筆(黒)", 60));
        items.Add(104, new Item(104, "鉛筆(赤)", 80));

        Console.Write("商品番号を入力してください->");
        int key = int.Parse(Console.ReadLine()!);
        if (items.ContainsKey(key))
        {
            Console.WriteLine(items[key]);
        }
        else
        {
            Console.WriteLine("該当する商品がありません。");
        }


    }
}
