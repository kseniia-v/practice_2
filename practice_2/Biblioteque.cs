using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace practice_2
{
    class Biblioteque
    {
        private IEnumerable<IGrouping<Opinion, Book>> result;
        public IEnumerable<IGrouping<Opinion, Book>> Result { get { return result; } set { result = value; } }
        public Biblioteque(List<Book> books)
        {
            this.result = GroupThem(books);
        }
        static IEnumerable<IGrouping<Opinion, Book>> GroupThem(List<Book> books)
        {
            return from book in books group book by book.Opinion;
        }
        public void PrintResult()
        {
            foreach (IGrouping<Opinion, Book> o in this.result)
            {
                Console.WriteLine($"here are {o.Key} books:");
                foreach (var b in o) Console.WriteLine(string.Format("{0} by {1}", b.Title, b.Author));
                Console.WriteLine();
            }
        }
    }
}
