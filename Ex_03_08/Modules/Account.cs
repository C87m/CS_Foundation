using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_08.Modules
{
    /// <summary>
    /// 口座情報のクラス
    /// </summary>
    public class Account
    {
        public string? AccountNo { get; set; }
        public string? AccountName { get; set; }
        public int Balance { get; set; } // 最大約20億なのでlongの方がよさそう

    }
}