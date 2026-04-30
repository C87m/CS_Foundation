using Ex_03_12.Modules;
namespace Ex_03_12;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("DVDのタイトルを入力してください->");
        Player dvd = new DVDPlayer(Console.ReadLine() ?? "無題");
        dvd.UseMachine();



        Console.Write("Blu-rayのタイトルを入力してください->");
        BlurayPlayer br = new BlurayPlayer(Console.ReadLine() ?? "無題");
        br.UseMachine();
        
    }
}
