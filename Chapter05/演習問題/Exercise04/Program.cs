//#define NonArray
#define StringArray

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            Stopwatch sw = new Stopwatch();
            sw.Start();
#if NonArray
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
#elif StringArray
            string[] lines = {
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=平澤輝久;BestWork=猿の惑星;Born=2003",
        };
#endif

#if NonArray
            var replaced = line.Replace("Novelist", "作家").Replace("BestWork", "代表作").Replace("Born", "誕生年").Replace("=", "：");

            var split = replaced.Split(';');

            foreach (var s in split) {
                Console.WriteLine(s);
#elif StringArray
            for (int i = 0; i < lines.Length; i++) {
                var replaced = lines[i].Replace("Novelist", "作家").Replace("BestWork", "代表作").Replace("Born", "誕生年").Replace("=", "：");
                var split = replaced.Split(';');

                foreach (var s in split) {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine("実行時間 = {0}", sw.Elapsed.ToString(@"ss\.fffff"));
#endif
        }
    }
}
