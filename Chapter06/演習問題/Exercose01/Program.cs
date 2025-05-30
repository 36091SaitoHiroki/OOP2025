﻿using System.Globalization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();

            Console.WriteLine();
            var cultureinfo = new CultureInfo("ja-JP");
            if (String.Compare(str1, str2, cultureinfo, CompareOptions.IgnoreKanaType) == 0) 
                Console.WriteLine("一致しています");
            else 
                Console.WriteLine("一致していない");
            

        }
    }
}
