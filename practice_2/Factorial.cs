using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace practice_2
{
    class Factorial
    {
        private int result1;
        private int result2;
        private int result3;
        public int Result1 { get { return result1; } set { result1 = value; } }
        public int Result2 { get { return result2; } set { result2 = value; } }
        public int Result3 { get { return result3; } set { result3 = value; } }
        public Factorial(int param)
        {
            this.result1 = CalcFactorial1(param);
            this.result2 = CalcFactorial2(param);
            this.result3 = CalcFactorial3(param);
        }
        static int CalcFactorial1(int x) 
        {
            int res = 1;
            for (int i = 1; i <= x; i++) res *= i;
            return res;
        }
        static int CalcFactorial2(int x)
        {
            int res = 1;
            if (x != 0) res = x * CalcFactorial2(x - 1);
            return res;
        }
        static int CalcFactorial3(int x)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= x; i++) { numbers.Add(i); }
            return numbers.Aggregate((x, y) => x * y);
        }
    }
}
