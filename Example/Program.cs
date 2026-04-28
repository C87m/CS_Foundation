namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        
        PrintHello();

        int answer = Add(4,5);
        Console.WriteLine(answer);

        void PrintHello()
        {
            Console.WriteLine("Hello, World!");
        }

        int Add(int x,int y)
        {
            return x + y;
        }


    }
}