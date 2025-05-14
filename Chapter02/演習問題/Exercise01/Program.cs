namespace Exercise01 {
    public class Program {
        static void Main(string[] args) {
            //2.1.3

            var songs = new List<Song>();


            //曲の登録を出力
            Console.Write("****** 曲の登録 ******");

            while (true) {
                //曲名出力
                Console.Write("曲名:");
                //入力された曲名取得
                string? title = Console.ReadLine();

                //endが入力されたら終了
                if (title.Equals("end", StringComparison.OrdinalIgnoreCase))
                    break;

                //アーティスト出力
                Console.Write("アーティスト名：");
                //入力されたアーティスト取得
                string? artistName = Console.ReadLine();

                //演奏時間出力
                Console.Write("演奏時間（秒）：");
                //入力された演奏時間取得
                int length = int.Parse(Console.ReadLine());

                //Songインスタンス生成
                //Song song = new Song(title, artistName, length);

                Song song = new Song() {
                    Title = title,
                    ArtistName = artistName,
                    Length = length
                };

                //歌データ登録
                songs.Add(song);

                Console.WriteLine();  //改行


            }
            printSongs(songs);
        }
        
        //2.1.4
        private static void printSongs(IEnumerable<Song> songs) {
            foreach (var song in songs) {
                var minutes = song.Length / 60;
                var seconds = song.Length % 60;
                Console.WriteLine($"{song.Title}, {song.ArtistName} {minutes}:{seconds:00}");
            }
            Console.WriteLine();
        }
    }
}
