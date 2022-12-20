using System;
using System.Linq;

namespace C097_プレゼント応募企画の実施 {
    class Program {
        static void Main(string[] args) {
            int[] input =  Console.ReadLine().Split(' ').Select(value => int.Parse(value)).ToArray();
            for(int n =1; n <= input[0]; n++){
                if(n % input[1] == 0 && n % input[2] == 0){
                    Console.WriteLine("AB");
                }else if(n % input[1] == 0){
                    Console.WriteLine("A");
                }else if (n % input[2] == 0) {
                    Console.WriteLine("B");
                }else{
                    Console.WriteLine("N");
                }
            }
        }
    }
}
