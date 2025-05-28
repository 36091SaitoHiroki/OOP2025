﻿
using System.Linq;
using System.Reflection;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            var books = new List<Book> {
                new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
                new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
                new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
                new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
                new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
                new Book { Title = "私でも分かったASP.NET Core", Price = 3200, Pages = 453 },
                new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };
            #region
            Console.WriteLine("7.2.1");
            Exercise1(books);

            Console.WriteLine("7.2.2");
            Exercise2(books);

            Console.WriteLine("7.2.3");
            Exercise3(books);

            Console.WriteLine("7.2.4");
            Exercise4(books);

            Console.WriteLine("7.2.5");
            Exercise5(books);

            Console.WriteLine("7.2.6");
            Exercise6(books);

            Console.WriteLine("7.2.7");
            Exercise7(books);
            #endregion

        }

        private static void Exercise1(List<Book> books) {
            var book = books.FirstOrDefault(x => x.Title.Contains("ワンダフル・C#ライフ"));
            if (book is not null)
                Console.WriteLine("{0} {1}", book.Price, book.Pages);
        }

        private static void Exercise2(List<Book> books) {
            var count = books
                .Count(x => x.Title.Contains("C#"));
            Console.WriteLine(count + "冊");
            
        }

        private static void Exercise3(List<Book> books) {
            var average = books
                .Where(x => x.Title.Contains("C#"))
                .Average(x => x.Pages);
            Console.WriteLine(average);
        }

        private static void Exercise4(List<Book> books) {
            var book = books
                .FirstOrDefault(x => x.Price >= 4000);
            if (book is not null) {
                Console.WriteLine(book.Title);
            }
            
        }

        private static void Exercise5(List<Book> books) {
            var pages = books
                .Where(x => x.Price < 4000)
                .Max(x => x.Pages);
            Console.WriteLine(pages);
        }

        private static void Exercise6(List<Book> books) {
            var selected = books
                .Where(x => x.Pages >= 400)
                .OrderByDescending(x => x.Price);
            foreach (var book in selected) {
                Console.WriteLine("{0} {1}", book.Title, book.Price);
            }
        }

        private static void Exercise7(List<Book> books) {
            var selected = books
                .Where(x => x.Title.Contains("C#") && x.Pages <= 500)
                .Select(x => x.Title);
            foreach (var title in selected) {
                Console.WriteLine(title);
            }
        }
    }
}
