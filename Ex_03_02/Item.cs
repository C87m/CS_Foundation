using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_02
{
    /// <summary>
    /// 商品情報を表すクラス
    /// </summary>
    public class Item
    {
        public int itemNo;
        public string itemName = ""; // 警告が出るので初期化
        public int price;

        public void Print(Item item)
        {
            Console.WriteLine("結果");

            Console.WriteLine($"商品番号 = {item.itemNo}");
            Console.WriteLine($"商品名 = {item.itemName}");
            Console.WriteLine($"単価 = {item.price}");
        }
        
    }
}