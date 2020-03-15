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
            return x > 0 ? res : 0;
        }
        static int CalcFactorial2(int x)
        {
            int res = 1; //int t = x;
            if (x > 1) res = x * CalcFactorial2(x - 1); 
            return x > 0 ? res : 0;
        }
        static int CalcFactorial3(int x)
        {
            try { return Enumerable.Range(1, x).Aggregate((a, b) => a * b); }
            catch (Exception e) { Console.WriteLine(e.Message); return 0; }
        }
    }
}
