namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        List<int> intList = new List<int>();
        intList.Add(6);
        intList.Add(3);
        intList.Add(5);
        intList.Add(7);

        Console.WriteLine($"intList[2]:{intList[2]}");
        intList[2] = 10;
        Console.WriteLine($"intList[2]:{intList[2]}");

        Console.Write("一覧表示:");
        ShowList(intList);

        Console.WriteLine($"intList.Count:{intList.Count}");
        Console.WriteLine($"intList.Contains(5):{intList.Contains(5)}");
        Console.WriteLine($"intList.Contains(9):{intList.Contains(9)}");

        intList.Insert(1,2);
        Console.WriteLine("intList.Insert(1,2):");
        Console.Write("一覧表示:");
        ShowList(intList);

        intList.Remove(3);
        Console.WriteLine("intList.Remove(3):");
        Console.Write("一覧表示:");
        ShowList(intList);

        intList.Sort();
        Console.WriteLine("intList.Sort():");
        Console.Write("一覧表示:");
        ShowList(intList);

        intList.Clear();
        Console.WriteLine("intList.Clear():");
        Console.Write("一覧表示:");
        ShowList(intList);

        void ShowList(List<int> intList)
        {
            foreach (int i in intList)
            {
                Console.Write(i);
            }   
            Console.WriteLine();
        }
    }
}