using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_07.Modules
{
    public class Item
    {
        public int ItemNo {get; set;}
        public string ItemName {get; set;}
        public int Price {get; set;}

        public void Print()
        {
            Console.WriteLine("結果");

            Console.WriteLine($"商品番号 = {ItemNo}");
            Console.WriteLine($"商品名 = {ItemName}");
            Console.WriteLine($"単価 = {Price}");
        }
    }
}