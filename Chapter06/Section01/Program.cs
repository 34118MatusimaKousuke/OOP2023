using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
            Console.WriteLine(numbers.Average());


            var books = Books.GetBooks();
            var price = books.Where(s => s.Title.Contains("物語")).Average(s => s.Pages);

            Console.WriteLine(price + "ページ");

        }
    }
}
