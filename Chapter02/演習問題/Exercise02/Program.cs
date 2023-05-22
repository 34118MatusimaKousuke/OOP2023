using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            if (args.Length < 3) {
                return;
            }
            if (args[0] == "-tom") {
                PrintInchToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            }
            else if (args[0] == "-toi") {
                PrintMeterToInchList(int.Parse(args[1]), int.Parse(args[2]));
            }
        }
        //フィートからメートルへの対応表を出力
        private static void PrintInchToMeterList(int start, int stop) {
            for (int Inch = start; Inch <= stop; Inch++) {
                double meter = InchConverter.FromMeter(Inch);
                Console.WriteLine("{0} inch = {1:0.0000} m", Inch, meter);
            }
        }

        //メートルからフィートへの対応表を出力
        private static void PrintMeterToInchList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double Inch = InchConverter.ToMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} inch", meter, Inch);
            }
        }
    }
}
