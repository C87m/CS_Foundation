namespace Example;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

static class Program
{
    static void Main(string[] args)
    {

        var item = new Item() { Id=100,Name="みかん",Price=150};

        var jsonStr = JsonConvert.SerializeObject(item);
        Console.WriteLine(jsonStr);

        var item2 = JsonConvert.DeserializeObject<Item>(jsonStr);
        Console.WriteLine(item2);

        JObject jsonObj = JObject.Parse(jsonStr);
        Console.WriteLine($"Id:{jsonObj["Id"]}");
        Console.WriteLine($"Name:{jsonObj["Name"]}");
        Console.WriteLine($"Price:{jsonObj["Price"]}");
    }
}