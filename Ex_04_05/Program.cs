namespace Ex_04_05;

static class Program
{
    static void Main(string[] args)
    {
        List<string> textList = new List<string>();
        while (true)
        {
            Console.Write("書き込むデータを入力してください->");
            string input = Console.ReadLine()!;
            if (input == "End")
            {
                break;
            }
            textList.Add(input);
        }
        TextFileAccessor.Write("exercise05.txt", textList);
        TextFileAccessor.ReadAndPrint("exercise05.txt");
    }
}
