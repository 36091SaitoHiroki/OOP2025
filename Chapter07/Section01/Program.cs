using System.Diagnostics;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var books = Books.GetBooks();

            //本の平均金額を表示
            Console.WriteLine((int)books.Average(x => x.Price));

            //ページ合計
            Console.WriteLine((int)books.Sum(x => x.Pages));

            //金額の安い書籍名と金額
            var book = books.Where(x => x.Price == books.Min(b => b.Price));
            foreach (var item in book) {
                Console.WriteLine(item.Title + ":" + item.Price);
            }



            //ページが多い書籍名とページ数
            books.Where(x => x.Pages == books
                          .Max(b => b.Pages)).ToList()
                          .ForEach(x => Console.WriteLine($"{x.Title} : {x.Pages}ページ"));

            //タイトルに「物語」が含まれる書籍名をすべて表示
            var titles = books.Where(x => x.Title.Contains("物語"));
            foreach (var item in titles) {
                Console.WriteLine(item.Title);
            }

        }
    }
}
