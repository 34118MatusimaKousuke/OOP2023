using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var price = Library.Books.Max(b => b.Price);

            var book = Library.Books
                              .First(b => b.Price == price);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var book = Library.Books.GroupBy(b => b.PublishedYear);

            foreach (var s in book) {
                Console.WriteLine("{0}年{1}冊",s.Key,s.Count());
            }
        }

        private static void Exercise1_4() {
            var books = Library.Books
                .OrderByDescending(b => b.PublishedYear)
                .ThenByDescending(b => b.Price)
                .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => new {
                    Title = book.Title,
                    Category = category.Name,
                    PublishedYear = book.PublishedYear,
                    Price = book.Price
                }
                );
            foreach (var s in books) {
                Console.WriteLine("{0}年 {1}円 {2} ({3})",s.PublishedYear,s.Price,s.Title,s.Category);
            }
        }

        private static void Exercise1_5() {
            var books = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => category.Name)
                .Distinct();

            foreach (var s in books) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise1_6() {
            var groups = Library.Categories
                .GroupJoin(Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, books) => new { Category = c.Name, Books = books }).OrderBy(x => x.Category);
            foreach (var s in groups) {
                Console.WriteLine("#{0}",s.Category);
                foreach (var n in s.Books) {
                    Console.WriteLine("   {0}",n.Title);
                }
            }
        }

        private static void Exercise1_7() {

        }

        private static void Exercise1_8() {
            var groups = Library.Categories
                .GroupJoin(Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, books) => new {
                    Category = c.Name,
                    Count = books.Count(),
                });

            foreach (var s in groups) {
                if (s.Count >=4) {
                  Console.WriteLine(s.Category);
                }
            }
        }
    }
}
