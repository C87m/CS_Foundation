namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        Human human = new();
        string s = human.ToString();
        Console.WriteLine(s);
        object o = human;
        Console.WriteLine(o.Equals(human));
    }
}