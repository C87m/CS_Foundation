namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        Warrior character = new();
        character.Name = "戦士";
        character.Hp = 10;//setアクセッサがprivateなので設定不可
        character.Ap = 10;//読み取り専用プロパティなので設定不可

    }
}