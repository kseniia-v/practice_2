using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x;
             do
             {
                 Console.WriteLine("enter x as positive value to calculate it as factorial and fibonacci member");
                 x = Convert.ToInt32(Console.ReadLine());
             }
             while (x < 0);
             */

            Console.WriteLine("enter x as positive value to calculate it as factorial and fibonacci member");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //1
            Console.WriteLine("Task #1");
            Fibonacci fibonacco = new Fibonacci(x);
            Console.WriteLine($"f({x}) = {fibonacco.Result1}");
            Console.WriteLine($"f({x}) = {fibonacco.Result2}");
            Console.WriteLine($"f({x}) = {fibonacco.Result3}");
            Console.WriteLine();
                        
            //2
            Console.WriteLine("Task #2");
            Factorial factorial = new Factorial(x);
            Console.WriteLine($"{x}! = {factorial.Result1}");
            Console.WriteLine($"{x}! = {factorial.Result2}");
            Console.WriteLine($"{x}! = {factorial.Result3}");
            Console.WriteLine();
            /*
            //3
            Console.WriteLine("Task #3");
            Book book1 = new Book { Title = "1984", Author = "George Orwell", Opinion = Opinion.Amazing };
            Book book2 = new Book { Title = "Citadelle", Author = "Antoine de Saint-Exupéry", Opinion = Opinion.Amazing };
            Book book3 = new Book { Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Opinion = Opinion.Dull };
            Book book4 = new Book { Title = "Atlas Shrugged", Author = "Ayn Rand", Opinion = Opinion.Dull };
            Book book5 = new Book { Title = "Demons", Author = "Fyodor Dostoevsky", Opinion = Opinion.Normal };
            var books = new List<Book> { book1, book2, book3, book4, book5 };

            Biblioteque library = new Biblioteque(books);
            library.PrintResult();
            Console.WriteLine();

            //4
            Console.WriteLine("Task #4");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            GroupArray grarr = new GroupArray(numbers);
            grarr.PrintResult();
            Console.WriteLine();

            Console.WriteLine($"even numbers");
            //grarr.PrintAGroup(grarr.Evens);
            grarr.PrintEvens();
            Console.WriteLine($"uneven numbers");
            //grarr.PrintAGroup(grarr.Unevens);
            grarr.PrintUnevens();
            */
            
        }
    }
}
