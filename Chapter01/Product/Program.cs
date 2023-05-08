using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    //商品クラス
    class Program {
        static void Main(string[] args) {

            #region P26のサンプルプログラム
            //インスタンス生成
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daihuku = new Product(124, "大福", 280);

            //Console.WriteLine(karinto.GetPriceIncludingTax());
            //Console.WriteLine(daihuku.GetPriceIncludingTax());
            #endregion

            //DateTime date = new DateTime(2023,5,8);
            DateTime date = DateTime.Today;

            
            //今日の日付
            Console.WriteLine("今日の日付:" + date );

            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);
            Console.WriteLine("十日後:" + daysAfter10);

            //10日前を求める
            DateTime daysbefore10 = date.AddDays(-10);
            Console.WriteLine("十日前:" + daysbefore10);
        }
    }
}
