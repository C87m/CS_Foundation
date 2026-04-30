using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_10.Modules
{
    public abstract class Player
    {
        public string Media { get; set; }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="Media">選択したメディア名</param>
        public Player(string Media)
        {
            this.Media = Media;
        }

        public abstract void Play();
        public abstract void Stop();
    }
}