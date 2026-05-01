using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_14
{
    public static class IntExtensions
    {
        public static int Add(this int a, int b)
        {
            return a + b;
        }

        public static double Average(this int a, int b)
        {
            return (a + b) / 2;
        }
    }
}