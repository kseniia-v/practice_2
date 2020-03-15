using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace practice_2
{
    class Fibonacci
    {
        private int result;
        public int Result { get { return result; } set { result = value; } }
        public Fibonacci(int param)
        {
            this.result = CalcFibonacci(param);
        }
        static int CalcFibonacci(int x)
        {
            int res = 0;
            if (x == 1) res = 1;
            if (x > 1) { res = CalcFibonacci(x - 1) + CalcFibonacci(x - 2); }
            return res;
        }
    }
}
