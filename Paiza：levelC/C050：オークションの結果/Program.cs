using System;
using System.Linq;

namespace C050_オークションの結果 {
    //    A さんと B さんがそれぞれ作成した自動取引プログラムが、ある商品を買うためにオークションに参加しています。

    //商品の値段は S 円から始まります。 A さんと B さんが、この順で交互に値段を上げていきます。

    //・A さんの作成した自動取引プログラムは今の商品の価格に 10 円を足した価格で交渉します。
    //・B さんの作成した自動取引プログラムは今の商品の価格に 1,000 円を足した価格で交渉します。
    //  A さんの予算は a 円、 B さんの予算は b 円です。自動取引プログラムは予算を超える価格で交渉をしようとすると停止します。

    //A さんと B さんのどちらが、いくらで商品を落札したかを出力してください。

    class Program {
        public string Name { get; set; }
        public int Budget { get; set; }
        public int Increase { get; set; }

        public Program(string vName, int vBudget, int vIncrease) {
            this.Name = vName;
            this.Budget = vBudget;
            this.Increase = vIncrease;
        }

        static void Main(string[] args) {
            var wCondition = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int wPrice = wCondition[0];//価格

            int wA_Increase = 10;//Aさんが足す額
            int wB_Increase = 1000;//Bさんが足す額

            Program wPersonA = new Program("A", wCondition[1], wA_Increase);//wCondition[1]は、Aさんの予算
            Program wPersonB = new Program("B", wCondition[2], wB_Increase);//wCondition[2]は、Bさんの予算
            Program wWiningPerson = new Program("", 0, 0);

            while (true) {
                if (wPrice > wPersonA.Budget - wPersonA.Increase) {
                    Console.WriteLine(wPersonB.Name + " " + wPrice);
                    break;
                }
                wPrice += wPersonA.Increase;
                if (wPrice > wPersonB.Budget - wPersonB.Increase) {
                    Console.WriteLine(wPersonA.Name + " " + wPrice);
                    break;
                }
                wPrice += wPersonB.Increase;
            }
        }
    }
}
