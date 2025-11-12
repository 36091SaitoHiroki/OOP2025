namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            //コード10.1  テキストファイルを一行ずつ読み込む
            //var filePath = "./Greeting.txt";
            //if (File.Exists(filePath)) {
            //    using var reader = new StreamReader(filePath, encoding.UTF8);
            //    while (!reader.EndOfStream) {
            //        var line = reader.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}

            //コード10.2  テキストファイルを一気に読み込む
            //var filePath = "./Greeting.txt";
            //var lines = File.ReadAllLines(filePath);
            //foreach (var line in lines) {
            //    Console.WriteLine(line);
            //}

            //コード10.3  テキストファイルをIEnumerable<string>として扱う
            //var filePath = "./Greeting.txt";
            //var lines = File.ReadLines(filePath);
            //foreach (var line in lines) {
            //    Console.WriteLine(line);
            //}

            //コード10.10  テキストファイルに一行ずつ文字列を出力
            //var filePath = "./Example/いろは歌.txt";
            //using(var writer = new StreamWriter(filePath)) {
            //    writer.WriteLine("色はにほへど　散りぬるを");
            //    writer.WriteLine("我が世たれぞ　常ならむ");
            //    writer.WriteLine("有為の奥山　今日越えて");
            //    writer.WriteLine("浅き夢見じ　酔ひもせず");
            //}

            //コード10.11  既存のテキストファイルの末尾に行を追加する
            //var lines = new[] { "====", "京の夢", "大阪の夢" };
            //var filePath = "./Example/いろは歌.txt";
            //using (var writer = new StreamWriter(filePath, append: true)) {
            //    foreach (var line in lines) {
            //        writer.WriteLine(line);
            //    }
            //}

            //コード10.12  文字列の配列を一気にファイルに出力
            //var lines = new[] { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", };
            //var filePath = "./Example/Cities.txt";
            //File.WriteAllLines(filePath,lines);

            //コード10.13  LINQクエリの結果をファイルに出力する
            //var names = new[] {"Tokyo","New Delhi","Bangkok","London","Paris",
            //                   "Berlin","Canberra","HingKong",};
            //var filePath = "./Example/Cities.txt";
            //File.WriteAllLines(filePath, names.Where(s => s.Length > 5));

            //コード10.14
            //var filePath = "./Example/いろは歌.txt";
            //using var stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            //using var reader = new StreamReader(stream);
            //using var writer = new StreamWriter(stream);
            //string texts = reader.ReadToEnd();
            //stream.Position = 0;
            //writer.WriteLine("挿入する新しい行１");
            //writer.WriteLine("挿入する新しい行２");
            //writer.WriteLine(texts);
        }
    }
}

































