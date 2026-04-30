using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_11.Modules
{
    public interface IUSB
    {
        /// <summary>
        /// つながっている装置にデータを送る機能の抽象メソッド
        /// </summary>
        void SendData();
        /// <summary>
        /// つながっている装置からデータを受け取る機能の抽象メソッド
        /// </summary>
        void ReciveData();
    }
}