using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_11.Modules
{
    public class Mouse : IUSB
    {
        public void SendData()
        {
            Console.WriteLine("PCにマウスの移動情報を送信しました");
        }

        public void ReciveData()
        {
            throw new NotImplementedException();
        }
    }
}