using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example
{
    internal class BookShelf
    {
        private static readonly int _bookNumMax = 10;
        private Book[] books = new Book[_bookNumMax];

        public Book this[int number]
        {
            get
            {
                if (number >= _bookNumMax || number < 0)
                {
                    Console.WriteLine("そのような場所はありません");
                    return null;
                }
                else
                {
                    return books[number];
                }
            }
            set
            {
                if (number >= _bookNumMax || number < 0)
                {
                    Console.WriteLine("そのような場所はありません");
                }
                else
                {
                    books[number] = value;
                }
            }
        }
    }
}