using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_11.Modules
{
    public class Display : IUSB
    {
        public void SendData()
        {
            throw new NotImplementedException();
        }

        public void ReciveData()
        {
            Console.WriteLine("ディスプレイに表示する情報を受信しました");
        }
    }
}