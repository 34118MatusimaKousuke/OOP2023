using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
            var nameDict = new Dictionary<char, int>();

            var replaced = text.ToUpper();

            foreach (var s in replaced) {
                if ('A' <= s && s <= 'Z') {
                    if (nameDict.ContainsKey(s))
                        nameDict[s]++;
                    else
                        nameDict[s] = 1;
                }
            }

            foreach (var s in nameDict.OrderBy(s => s.Key)) {
                Console.WriteLine("'{0}'： {1}", s.Key, s.Value);
            }
        }

        private static void Exercise1_2(string text) {
            var nameDict = new SortedDictionary<Char, int>();
            var replaced = text.ToUpper();

            foreach (var s in replaced) {
                if ('A' <= s && s <= 'Z') {
                    if (nameDict.ContainsKey(s))
                        nameDict[s]++;
                    else
                        nameDict[s] = 1;
                }
            }

            foreach (var s in nameDict) {
                Console.WriteLine("'{0}'： {1}", s.Key, s.Value);
            }
        }
    }
}
