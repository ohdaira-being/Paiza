using System;

namespace Paiza_D172_イヴの日付 {
    class Program {
        static void Main(string[] args) {
            //あなたはカレンダーのプログラムを作成しています。
            //クリスマスイヴなど記念日の前日をイヴとして計算して表示しようと考えてます。
            //日付が入力されるのでその日付の 1 日前を出力してください。

            //3回目の提出
            Console.WriteLine("記念日の年（西暦）・月・日をyyyy/MM/ddのように入力してください。（例えば、1996年11月19日の場合：1996/11/19）");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime day)) {
                Console.WriteLine("入力が正しくありません。記念日の年（西暦）・月・日をyyyy/MM/ddのように入力してください。（例えば、1996年11月19日の場合：1996/11/19）");
                return;
            }
            string eveday = day.AddDays(-1).ToString("yyyy年MM月dd日");
            Console.WriteLine("イヴの日付は、" + eveday + "です。");
        }
    }
}
