using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise01 {
    class ToHankakuProcessor : TextProcessor{

        private static Dictionary<char, char> _dictionary =
           new Dictionary<char, char>() {
                {'０','1'},{'１','1'},{'２','2'},{'３','3'},{'４','4'},
                {'５','5'},{'６','6'},{'７','7'},{'８','8'},{'９','9'}
           };

        protected override void Execute(string line) {
            foreach (var s in _dictionary) {
                line = Regex.Replace(line,s.Key.ToString(),s.Value.ToString());
            }
            Console.WriteLine(line);
        }

        protected override void Terminate() {
        }
    }
}
