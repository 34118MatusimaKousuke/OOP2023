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

            #region タイトルに物語を含む本の平均ページ数出力
            var books = Books.GetBooks();
            var page = books.Where(s => s.Title.Contains("物語")).Average(s => s.Pages);

            Console.WriteLine(page + "ページ");
            #endregion

            #region タイトルの長い順に出力
            var title = books.OrderByDescending(s => s.Title.Length);
            foreach (var s in title) {
                Console.WriteLine(s.Title);

            }
            #endregion
        }
    }
}
