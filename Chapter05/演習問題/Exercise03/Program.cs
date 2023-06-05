using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            var count = text.Count(s => s == ' ');
            Console.WriteLine("空白数：" + count);
        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            var count = text.Split(' ').Count();
            Console.WriteLine("単語数：" + count);
        }

        private static void Exercise3_4(string text) {
            var count = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var s in count) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise3_5(string text) {
            var word = text.Split(' ').ToList();
            var sb = new StringBuilder();
            foreach (var s in word) {
                sb.Append(s + ' ');
            }
            var t1 = sb.ToString();
            Console.WriteLine(t1);
        }
    }
}
