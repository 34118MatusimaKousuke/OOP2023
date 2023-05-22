using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");
            var amountPetCategory = sales.GetPerCategorySales();
            var amountPetStore = sales.GetPerStoreSales();

            Console.WriteLine("**売上集計**");
            Console.WriteLine("1.店舗別売上");
            Console.WriteLine("2.商品カテゴリー別売上");
            Console.Write(">");
            int  select = int.Parse(Console.ReadLine());

            if (select == 1) {
                foreach (var obj in amountPetStore) {
                    Console.WriteLine(String.Format("{0}{1:#,0}", obj.Key, obj.Value));
                }
            }else if (select == 2) {
                foreach (var obj in amountPetCategory) {
                    Console.WriteLine(String.Format("{0}{1:#,0}", obj.Key, obj.Value));
                }
            }
        }
    }
}
