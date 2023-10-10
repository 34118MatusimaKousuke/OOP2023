using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            var lines = File.ReadAllLines("sample.txt");
            var pattern1 = @"(V|v)ersion\s*=\s*""4.0""";
            for (int i = 0; i < lines.Length; i++) {
                lines[i] = Regex.Replace(lines[i], pattern1, @"version=""v5.0""");

            }
            //書き込み
            File.WriteAllLines("sample.txt",lines);





            // これ以降は確認用
            var text = File.ReadAllText("sample.txt");
            Console.WriteLine(text);
        }
    }
}
