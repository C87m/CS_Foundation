using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_13
{
    public class Circle
    {
        public static double PI = 3.14;
        int radius;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="pradius">半径</param>
        public Circle(int pradius)
        {
            radius = pradius;
        }

        public double AreaCalculation()
        {
            return PI * radius * radius;
        }

        public static double AreaCalculation(int radius)
        {
            return PI * radius * radius;
        }
    }
}