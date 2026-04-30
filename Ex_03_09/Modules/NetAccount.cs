using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_09.Modules
{
    public class NetAccount : Account
    {
        public int Point { get; set; }

        public NetAccount(string AccountNo, string AccountName, int Balance, int Point) : base(AccountNo, AccountName, Balance)
        {
            this.Point = Point;
        }
    

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"ポイント：{Point}");

        }

        public override string ToString()
        {
            return $"NetAccount[{base.ToString()},Point={Point}]";
        }
    }
}