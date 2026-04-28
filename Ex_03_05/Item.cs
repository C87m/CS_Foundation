using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_05
{
    /// <summary>
    /// 商品情報を表すクラス
    /// </summary>
    public class Item
    {
        public int itemNo;
        public string itemName = ""; // 警告が出るので初期化
        public int price;
        public double salesTaxRate = 0.10;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Item(int pitemNo, string pitemName, int pprice)
        {
            itemNo = pitemNo;
            itemName = pitemName;
            price = pprice;
        }

        public void Print()
        {
            Console.WriteLine("結果");

            Console.WriteLine($"商品番号 = {itemNo}");
            Console.WriteLine($"商品名 = {itemName}");
            Console.WriteLine($"単価 = {price}");
        }
        
        public void ChangePrice(int pprice)
        {
            price = pprice;
        }

        public int CalculateTaxAmount()
        {
            return (int)(price * (1 + salesTaxRate));
        }
    }
}