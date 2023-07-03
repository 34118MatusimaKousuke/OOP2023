using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            //var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            var dateTime = DateTime.Now;
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            Console.WriteLine("{0} {1}",dateTime.ToString("d"),dateTime.ToString("t"));
        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            var s5 = dateTime.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            Console.WriteLine(s5);
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            var culuture = new CultureInfo("ja-JP");
            culuture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = dateTime.ToString("ggyy年M月d日 (dddd)",culuture);
            Console.WriteLine(str);
        }

        private static void DisplayDatePattern3_2(DateTime dateTime) {
        }
    }
}
