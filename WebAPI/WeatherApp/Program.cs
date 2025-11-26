using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WeatherApp {
    internal class Program {
        // 主要都市の緯度・経度データをプログラム内に保持
        private static readonly Dictionary<string, (double Latitude, double Longitude)> Locations = new Dictionary<string, (double, double)>(StringComparer.OrdinalIgnoreCase)
        {
            { "北海道", (43.0642, 141.3469) }, { "青森県", (40.8247, 140.7400) }, { "岩手県", (39.7036, 141.1525) },
            { "宮城県", (38.2688, 140.8721) }, { "秋田県", (39.7186, 140.1024) }, { "山形県", (38.2404, 140.3636) },
            { "福島県", (37.7503, 140.4676) }, { "茨城県", (36.3418, 140.4468) }, { "栃木県", (36.5657, 139.8836) },
            { "群馬県", (36.3912, 139.0601) }, { "埼玉県", (35.8569, 139.6489) }, { "千葉県", (35.6047, 140.1233) },
            { "東京都", (35.6895, 139.6917) }, { "神奈川県", (35.4478, 139.6426) }, { "新潟県", (37.9024, 139.0232) },
            { "富山県", (36.6953, 137.2114) }, { "石川県", (36.5947, 136.6256) }, { "福井県", (36.0652, 136.2217) },
            { "山梨県", (35.6642, 138.5684) }, { "長野県", (36.6515, 138.1810) }, { "岐阜県", (35.3919, 136.7222) },
            { "静岡県", (34.9769, 138.3849) }, { "愛知県", (35.1802, 136.9066) }, { "三重県", (34.7303, 136.5086) },
            { "滋賀県", (35.0045, 135.8685) }, { "京都府", (35.0211, 135.7538) }, { "大阪府", (34.6864, 135.5200) },
            { "兵庫県", (34.6912, 135.1942) }, { "奈良県", (34.6851, 135.8328) }, { "和歌山県", (34.2260, 135.1676) },
            { "鳥取県", (35.5037, 134.2376) }, { "島根県", (35.4722, 133.0505) }, { "岡山県", (34.6552, 133.9195) },
            { "広島県", (34.3965, 132.4596) }, { "山口県", (34.1857, 131.4729) }, { "徳島県", (34.0658, 134.5595) },
            { "香川県", (34.3401, 134.0435) }, { "愛媛県", (33.8416, 132.7661) }, { "高知県", (33.5597, 133.5311) },
            { "福岡県", (33.6063, 130.4187) }, { "佐賀県", (33.2494, 130.2988) }, { "長崎県", (32.7502, 129.8739) },
            { "熊本県", (32.7898, 130.7416) }, { "大分県", (33.2381, 131.6125) }, { "宮崎県", (31.9111, 131.4239) },
            { "鹿児島県", (31.5603, 130.5580) }, { "沖縄県", (26.2124, 127.6809) }
        };

        static async Task Main(string[] args) {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== 緯度経度から最寄り都道府県を検索し天気表示 ===");

            try {
                Console.Write("緯度（例: 35.6895）：");
                if (!double.TryParse(Console.ReadLine(), out double latitude)) {
                    Console.WriteLine("緯度の形式が正しくありません (ピリオドを使用してください)。"); return;
                }
                Console.Write("経度（例: 139.6917）：");
                if (!double.TryParse(Console.ReadLine(), out double longitude)) {
                    Console.WriteLine("経度の形式が正しくありません (ピリオドを使用してください)。"); return;
                }

                // 最も近い都道府県を計算で探す
                string nearestPrefecture = FindNearestPrefecture(latitude, longitude);

                // ここで都道府県名を出力
                Console.WriteLine($"\n入力された地点に最も近い都道府県は「{nearestPrefecture} 」です。");

                // --- ここから、その地点の天気情報を表示 ---
                var location = Locations[nearestPrefecture];
                using var http = new HttpClient();

                // GetWeatherInfoを呼び出す（location.Latitudeとlocation.Longitudeを使用）
                await GetWeatherInfo(http, location.Latitude, location.Longitude, nearestPrefecture);

            }
            catch (Exception ex) {
                Console.WriteLine($"エラー：{ex.Message}");
            }
        }

        static string FindNearestPrefecture(double userLat, double userLon) {
            double minDistance = double.MaxValue;
            string nearestPrefecture = "不明";

            foreach (var kvp in Locations) {
                double lat = kvp.Value.Latitude;
                double lon = kvp.Value.Longitude;
                double distance = Math.Sqrt(Math.Pow(userLat - lat, 2) + Math.Pow(userLon - lon, 2));

                if (distance < minDistance) {
                    minDistance = distance;
                    nearestPrefecture = kvp.Key;
                }
            }
            return nearestPrefecture;
        }

        static async Task GetWeatherInfo(HttpClient http, double latitude, double longitude, string locationName) {

            string weatherUrl = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&hourly=temperature_2m&current=temperature_2m,relative_humidity_2m,wind_speed_10m";

            // Open-Meteo API から天気情報を取得
            var weather = await http.GetFromJsonAsync<WeatherResponse>(weatherUrl);

            Console.WriteLine($"\n--- {locationName} の天気情報 ---");
            if (weather?.current != null) {
                Console.WriteLine($"取得時刻：{weather.current.time}");
                Console.WriteLine($"気温：{weather.current.temperature_2m} ℃");
                Console.WriteLine($"風速：{weather.current.wind_speed_10m} m/s");
                Console.WriteLine($"湿度：{weather.current.relative_humidity_2m} ％");
            } else {
                Console.WriteLine("天気データが取得できませんでした。");
            }
        }
    }
}