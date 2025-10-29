﻿
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();

        }

        private static void Exercise1_2() {
            var book = Library.Books
                              .MaxBy(b => b.Price);

            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var results = Library.Books
                                 .GroupBy(b => b.PublishedYear)
                                 .OrderBy(b=>b.Key)
                                 .Select(b => new {
                                     PublishedYear = b.Key,
                                     Count = b.Count()
                                 });

            foreach (var item in results) {
                Console.WriteLine($"{item.PublishedYear}:{item.Count}");
            }
            
        }

        private static void Exercise1_4() {
            var book = Library.Books
                              .OrderByDescending(b => b.Price)
                              .ThenByDescending(b => b.PublishedYear);
            foreach (var item in book) {
                Console.WriteLine($"{item.PublishedYear}年 {item.Price}円 {item.Title}");
            }
        }

        private static void Exercise1_5() {
            var book = Library.Books
                              .Where(b => b.PublishedYear == 2022)
                              .Join(Library.Categories,
                                book => book.CategoryId,
                                category => category.Id,
                                (book, category) => category.Name)
                              .Distinct();
            foreach (var books in book) {
                Console.WriteLine(books);
            }
                              
                              
        }

        private static void Exercise1_6() {
            
        }

        private static void Exercise1_7() {
            
        }

        private static void Exercise1_8() {
            
        }
    }
}
