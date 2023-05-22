using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");
            var amountPetStore = sales.GetPerStoreSales();
            foreach (var obj in amountPetStore) {
                Console.WriteLine(String.Format("{0}{1:#,0}", obj.Key, obj.Value));
            }
        }
    }
}
