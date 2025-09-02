using System.Text.RegularExpressions;
namespace Section02 {
    internal class Program {
        static void Main(string[] args) {

            var strings = new[] {
                "Microsoft Windows",
                "windows",
                "Windows Server",
                "Windows",
            };

            var regex = new Regex(@"^(W|w)indows$");

            var count = strings.Count(s => regex.IsMatch(s));
            Console.WriteLine($"{count}行と一致");

            //パターンと完全に一致している文字列

            var datas = strings.Where(s => regex.IsMatch(s));
            foreach (var item in datas) {
                Console.WriteLine(item);
            }

        }
    }
}
