namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            //コード10.1  テキストファイルを一行ずつ読み込む

            var filePath = "./Greeting.txt";
            if (File.Exists(filePath)) {
                using var reader = new StreamReader(filePath, encoding.UTF8);
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }


        }
    }
}
