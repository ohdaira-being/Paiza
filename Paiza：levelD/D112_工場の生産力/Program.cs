using System;

namespace D112_工場の生産力 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("1時間当たりに流れてくる商品の個数nを入力してください。");
            if (!int.TryParse(Console.ReadLine(), out int n)) {
                Console.WriteLine("0以上の整数を入力してください。");
                return;
            }
            if (n < 0) {
                Console.WriteLine("0以上の整数を入力してください。");
            }
            Console.WriteLine("1日当たりの工場の稼働時間hを入力してください。");
            if (!int.TryParse(Console.ReadLine(), out int h)) {
                Console.WriteLine("0以上の整数を入力してください。");
                return;
            }
            if (h < 0) {
                Console.WriteLine("0以上の整数を入力してください。");
            }
            Console.WriteLine("1日で" + n * h + "個生産しています。");
        }
    }
}
