using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var dateTime = DateTime.Now;
            //var dateTime = new DateTime(2017, 1, 1);
            var s1 = dateTime.ToString("yy/MM/dd(ddd)");
            foreach (var s in Enum.GetValues(typeof(DayOfWeek))) {
                var s3 = NextWeek(dateTime, (DayOfWeek)s).ToString("yy/MM/dd(ddd)");
                Console.WriteLine("{0}次週の{1}：{2}", s1, s, s3);
            }
        }
        public static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if (days >= -1)
                days += 7;
            return date.AddDays(days);
        }
    }
}
