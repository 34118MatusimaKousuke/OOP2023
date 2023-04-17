using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {

            string[] money = { "一万円札", "五千円札", "二千円札", "千円札", "五百円玉", "百円玉", "五十円玉", "十円玉", "一円玉" };
            int[] money1 = { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 1 };

            Console.Write("金額:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("支払い:");
            int num2 = int.Parse(Console.ReadLine());

            int num = num2 - num1;
            Console.WriteLine("お釣り:" + num);
            for (int i = 0; i < money.Length; i++)
            {
                Console.Write(money[i] + ":" + num / money1[i] + "枚");
                ast(num / money1[i]);
                num %= money1[i];
            }
        }

            private static void ast(int count) {
                for (int i = 0; i < count; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
        }
    }
}

