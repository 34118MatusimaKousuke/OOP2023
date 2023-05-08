using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    //商品クラス
    class Program {
        static void Main(string[] args) {

            //インスタンス生成
            Product karinto = new Product(123, "かりんとう", 180);
            Product daihuku = new Product(124, "大福", 280);
            Console.WriteLine(karinto.GetPriceIncludingTax());
            Console.WriteLine(daihuku.GetPriceIncludingTax());

        }
    }
}
