using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_10.Modules
{
    public class DVDPlayer : Player
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="Media"></param>
        public DVDPlayer(string Media) : base(Media){}

        public override void Play()
        {
            Console.WriteLine($"DVD：{Media}を再生しています");
        }

        public override void Stop()
        {
            Console.WriteLine($"DVD：{Media}の再生を停止しました");
        }
    }
}