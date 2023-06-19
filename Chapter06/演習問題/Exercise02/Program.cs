using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);
        }

        private static void Exercise2_1(List<Book> books) {
            var name = books.Where(s => s.Title == "ワンダフル・C#ライフ");
            foreach (var s in name) {
                Console.WriteLine("価格：" + s.Price + " ページ数：" + s.Pages);
            }
        }

        private static void Exercise2_2(List<Book> books) {
            var count = books.Count(s => s.Title.Contains("C#"));
            Console.WriteLine(count + "冊");
        }

        private static void Exercise2_3(List<Book> books) {
            var avg = books.Where(s => s.Title.Contains("C#")).Average(s => s.Pages);
            Console.WriteLine(avg + "ページ数");
        }

        private static void Exercise2_4(List<Book> books) {
            var price = books.Where(s => s.Price >= 4000).Take(1);
            foreach (var s in price) {
                Console.WriteLine(s.Title);
            }
        }

        private static void Exercise2_5(List<Book> books) {
            var max = books.Where(s => s.Price < 4000).Max(s => s.Pages);
            Console.WriteLine(max);
        }

        private static void Exercise2_6(List<Book> books) {
            var pay = books.Where(s => s.Pages >= 400).OrderByDescending(s => s.Price);
            foreach (var s in pay) {
                Console.WriteLine(s.Title + "：" +  s.Price + "円");
            }
        }

        private static void Exercise2_7(List<Book> books) {
            var name = books.Where(s => s.Title.Contains("C#")).Where(s => s.Pages <= 500);
            foreach (var s in name) {
                Console.WriteLine(s.Title);
            }
        }
    }

    class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
}
