namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        throw new MyException("エラーコード","エラー発生");
    }
}