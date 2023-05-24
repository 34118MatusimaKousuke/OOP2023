using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Console.WriteLine("***** 3.1 *****");
            Exercise2_1(names);
            Console.WriteLine("***** 3.2 *****");
            Exercise2_2(names);
            Console.WriteLine("***** 3.3 *****");
            Exercise2_3(names);
            Console.WriteLine("***** 3.4 *****");
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力。空行で終了");
            do {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) {
                    break;
                }
                var find = names.FindIndex(s => s == line);

                Console.WriteLine(find);
            } while (true);
        }

        private static void Exercise2_2(List<string> names) {
            var count = names.Where(s => s.Contains('o')).Count();
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var ocity = names.Where(s => s.Contains('o')).ToList();
            foreach (var s in ocity) {
                Console.WriteLine(s);
            }
        }
        private static void Exercise2_4(List<string> names) {
            var list = names.Where(s => s[0] == 'B').Select(s => s.Length);
            foreach (var s in list) {
                Console.WriteLine(s);

            }
        }
    }
}
