namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("はじめ:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("おわり:");
            int end = int.Parse(Console.ReadLine());

            if (args.Length >= 1 && args[0] == "-tom") {
                PrintInchToMeterList(start, end);
            } else {
                PrintMeterToInchList(start, end);
            }

            //フィートからメートルへの対応表を出力
            static void PrintInchToMeterList(int start, int end) {
                for (int inch = start; inch <= end; inch++) {
                    double meter = inchConverter.ToMeter(inch);
                    Console.WriteLine($"{inch} inch = {meter:0.0000}m");
                }
            }

            //メートルからフィートへの対応表を出力
            static void PrintMeterToInchList(int start, int end) {
                for (int meter = start; meter <= end; meter++) {
                    double inch = inchConverter.FromMeter(meter);
                    Console.WriteLine($"{meter} m = {inch:0.0000}inch");
                }
            }
        }
    }
}
