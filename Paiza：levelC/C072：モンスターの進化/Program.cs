using System;
using System.Linq;

namespace C072_モンスターの進化 {
    class Program {
        static void Main(string[] args) {
            int[] input = Console.ReadLine().Split(' ').Select(value => int.Parse(value)).ToArray();
            int.TryParse(Console.ReadLine(), out int N);
            string[] output = { };
            for (int n = 1; n <= N; n++) {
                string[] monster = Console.ReadLine().Split(' ');
                int[] state = new string[] { monster[1], monster[2], monster[3], monster[4], monster[5], monster[6] }.Select(value => int.Parse(value)).ToArray();
                if (state[0] <= input[0] && input[0] <= state[1] && state[2] <= input[1] && input[1] <= state[3] && state[4] <= input[2] && input[2] <= state[5]) {
                    Array.Resize(ref output, output.Length + 1);
                    output[output.Length - 1] = monster[0];

                }
            }
            if (output.Length > 0) {
                Console.WriteLine(string.Join("\r\n", output));
            } else {
                Console.WriteLine("no evolution");
            }

        }
    }
}
