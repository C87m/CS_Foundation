using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_16
{
    public class InputParameterLessThanZeroException : Exception
    {
        public InputParameterLessThanZeroException(int param) : base($"xに{param}が入力されました。正の値を入力してください。"){}
    }
}