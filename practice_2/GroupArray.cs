using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace practice_2
{
    class GroupArray
    {
        private IEnumerable<int> evens;
        private IEnumerable<int> unevens;
        private IEnumerable<IGrouping<bool, int>> result;
        public IEnumerable<int> Evens { get { return evens; } set { evens = value; } }
        public IEnumerable<int> Unevens { get { return unevens; } set { unevens = value; } }
        public IEnumerable<IGrouping<bool, int>> Result { get { return result; } set { result = value; } }
        public GroupArray(int[] numbers)
        {
            this.unevens = Split(numbers,true);
            this.evens = Split(numbers,false);
            this.result = GroupThem(numbers);
        }
        static IEnumerable<int> Split(int[] numbers, bool isEven)
        {
            return from i in numbers
                   where i % 2 == Convert.ToInt32(isEven)
                   select i;
        }
        static IEnumerable<IGrouping<bool, int>> GroupThem(int[] numbers)
        {
            return from i in numbers group i by i % 2 == 0;
        }
        public void PrintResult()
        {
            foreach (IGrouping<bool, int> n in this.result)
            {
                Console.WriteLine($"where number is even – {n.Key}:");
                foreach (var x in n) Console.Write(x + " ");
                Console.WriteLine();
            }
        }
        public void PrintAGroup(IEnumerable<int> groupped)
        {
            foreach (int x in groupped) Console.Write(x + " ");
            Console.WriteLine();
        }
        public void PrintEvens()
        {
            foreach (int x in this.evens) Console.Write(x + " ");
            Console.WriteLine();
        }
        public void PrintUnevens()
        {
            foreach (int x in this.unevens) Console.Write(x + " ");
            Console.WriteLine();
        }

    }
}
