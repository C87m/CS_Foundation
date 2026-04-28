using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_01
{
    /// <summary>
    /// 商品情報を表すクラス
    /// </summary>
    public class Item
    {
        public int itemNo;
        public string itemName = ""; // 警告が出るので初期化
        public int price;
        
    }
}