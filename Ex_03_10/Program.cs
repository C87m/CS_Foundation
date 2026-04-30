using Ex_03_10.Modules;
namespace Ex_03_10;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("DVDのタイトルを入力してください->");
        DVDPlayer dvd = new(Console.ReadLine() ?? "無題");
        dvd.Play();
        dvd.Stop();

        Console.Write("Blu-rayのタイトルを入力してください->");
        BlurayPlayer br = new(Console.ReadLine() ?? "無題");
        br.Play();
        br.Stop();
    }
}
