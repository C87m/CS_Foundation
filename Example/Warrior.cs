using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example
{
    /// <summary>
    /// 戦士を表すクラス
    /// </summary>
    public class Warrior
    {
        private string name;     // 名前を表すフィールド
        private int hp = 10;     // 体力を表すフィールド
        private int ap = 5;      // 攻撃力を表すフィールド
        private int dp;          // 防御力を表すフィールド
        // 名前のプロパティ
        public string Name
        {
            get { return name; }   // getアクセッサ
            set { name = value; }  // setアクセッサ
        }
        // 体力のプロパティ
        public int Hp
        {
            get { return hp; } // getアクセッサ
            private set
            {
                if (value > 0)
                {
                    hp = value;
                }
                else
                {
                    hp = 0;
                }
            }// setアクセッサ
        }
        // 攻撃力のプロパティ（読み取り専用）
        public int Ap
        {
            get { return ap; }
        }
        // 防御力のプロパティ（読み取り専用）
        public int Dp
        {
            get { return dp; }
        }
    }
}