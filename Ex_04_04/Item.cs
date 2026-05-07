using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_04_04
{
    public class Item
    {
        public int Id {get; set;}
        public string? Name {get; set;}
        public int Price{get; set;}

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Item(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Item[Id={Id} , Name={Name} , Price={Price}]";
        }
    }
}