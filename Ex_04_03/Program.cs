using System.Diagnostics.CodeAnalysis;
using Ex_04_03.Modules;
namespace Ex_04_03;

static class Program
{
    static void Main(string[] args)
    {
        List<string> emp = new List<string>();
        while(true)
        {
            Console.Write("社員番号を入力してください->");
            string empNo = Console.ReadLine()??"";
            if(empNo == "End")
            {
                break;
            }
            emp.Add(empNo);

            Console.Write("社員名を入力してください->");
            emp.Add(Console.ReadLine()??"");

            Console.Write("住所を入力してください->");
            emp.Add(Console.ReadLine()??"");
        }

        for(int i=0; i<emp.Count/3; i++)
        {
            Employee e = new(int.Parse(emp[i*3]), emp[i*3+1], emp[i*3+2]);
            Console.WriteLine(e);
        }

    }
}
