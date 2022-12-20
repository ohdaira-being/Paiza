using System;
using System.Linq;


namespace C035_試験の合格判定 {
    class Program {
        static void Main(string[] args) {
            //総合力を重視する paiza 大学の入試では 1 次試験(英語、数学、理科、国語、地理歴史の 5 科目で各 100 点満点) の成績で2段階選抜を行います。2段階選抜を通過する条件は以下のようになっています。

            //全科目の合計得点が 350 点以上
            //理系の受験者の場合は理系 2 科目(数学、理科) の合計得点が 160 点以上
            //文系の受験者の場合は文系 2 科目(国語、地理歴史) の合計得点が 160 点以上
            //受験者それぞれの各科目の点数が入力されるので、何人2段階選抜を通過できるかを求めてください。

            int.TryParse(Console.ReadLine(), out int N);
            int passing = 0;
            for (int n = 1; n <= N; n++) {
                string[] input = Console.ReadLine().Split(' ');
                int[] score = new string[] { input[1], input[2], input[3], input[4], input[5] }.Select(value => int.Parse(value)).ToArray();
                //int[] score = input[1..6].Select(value => int.Parse(value)).ToArray();
                int result = score.Sum();
                switch (input[0]) {
                    case "s":
                        if (score[1] + score[2] >= 160 && result >= 350) {
                            passing += 1;
                        }
                        break;
                    case "l":
                        if (score[3] + score[4] >= 160 && result >= 350) {
                            passing += 1;
                        }
                        break;
                    default:
                        Console.WriteLine("成績を入力してください");
                        break;
                }
            }
            Console.WriteLine(passing);
        }
    }
}
