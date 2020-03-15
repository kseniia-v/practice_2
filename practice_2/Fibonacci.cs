using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace practice_2
{
    class Fibonacci
    {
        private int result1;
        private int result2;
        private int result3;
        public int Result1 { get { return result1; } set { result1 = value; } }
        public int Result2 { get { return result2; } set { result2 = value; } }
        public int Result3 { get { return result3; } set { result3 = value; } }
        public Fibonacci(int param)
        {
            this.result1 = CalcFibonacci1(param);
            this.result2 = CalcFibonacci2(param);
            this.result3 = CalcFibonacci3(param);
        }
        //1
        static int CalcFibonacci1(int x)
        {
            int res = 0;
            if (x == 1) res = 1;
            if (x > 1) { res = CalcFibonacci1(x - 1) + CalcFibonacci1(x - 2); }
            return res;
        }
        //2
        static int CalcFibonacci2(int x)
        {
            int res = 0;
            res = x >= 0 ? Seq(x)[x] : 0;
            return res;
        }
        static List<int> Seq(int member)
        {
            List<int> sequence = new List<int>();
            for (int i = 0; i <= member; i++)
            {
                int x = 0;
                if (i == 0 || i == 1) x = i;
                if (i == 2) x = 1;
                if (i > 2) x = sequence[i - 1] + sequence[i - 2];
                sequence.Add(x);
            }
            return sequence;
        }
        //3
        static int CalcFibonacci3(int a)
        {
            var ini = Enumerable.Range(0, 2);
            var res = ini;
            if(a > 0) res = Enumerable.Range(1, a).Select((x, i) => i > 1 ? res.ElementAt(i - 1) + res.ElementAt(i - 2) : ini.Aggregate((x, y) => x + y));
            return a > 0 ? res.Last() : 0;
        }

    }
}
