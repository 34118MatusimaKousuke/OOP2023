using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            #region 花
            var flowerDict = new Dictionary<string, int>() {
                ["sunflower"] = 400,
                ["pansy"] = 300,
                ["tulip"] = 350,
                ["rose"] = 500,
                ["dahlia"] = 450,
            };

            flowerDict["morning glory"] = 250;

            Console.WriteLine("ひまわりの価格は{0}円です", flowerDict["sunflower"]);
            Console.WriteLine("チューリップの価格は{0}円です", flowerDict["tulip"]);
            Console.WriteLine("あさがおの価格は{0}円です", flowerDict["morning glory"]);
            Console.WriteLine();
            #endregion

            Console.WriteLine("県庁所在地の登録");

            var prefectureDict = new Dictionary<string, CityInfo>();    
            Console.Write("県名：");
            var prefecturename = Console.ReadLine();

            while (prefecturename != "999") {
                var cityinfo = new CityInfo();
                Console.Write("所在地：");
                cityinfo.City = Console.ReadLine();
                Console.Write("人口：");
                cityinfo.Population = int.Parse(Console.ReadLine());

                if (prefectureDict.ContainsKey(prefecturename)) {
                    Console.WriteLine("もうすでに{0}県は登録されています上書きしますか？", prefecturename);
                    Console.WriteLine("上書き：0 上書きしない：1");
                    var judge = Console.ReadLine();
                    if (int.Parse(judge) == 0) {
                        prefectureDict[prefecturename] = cityinfo;
                    }   
                }
                else {
                    prefectureDict[prefecturename] = cityinfo;

                }
                Console.Write("県名：");
                prefecturename = Console.ReadLine();
            }
            Console.WriteLine("1：一覧表示,2：県名指定");
            Console.Write("＞");
            var judgement = Console.ReadLine();
            if (int.Parse(judgement) == 1) {
                var pre = prefectureDict.OrderByDescending(s => s.Value.Population);
                foreach (var s in pre) {
                    Console.WriteLine("{0}{1}{2}",s.Key,s.Value.City,s.Value.Population);
                }
            }else if (int.Parse(judgement) == 2) {
                Console.Write("県名：");
                var prefecturename2 = Console.ReadLine();
                Console.WriteLine("{0}県", prefectureDict[prefecturename2].City);
                Console.WriteLine("人口：{0}人",prefectureDict[prefecturename2].Population);
            }
        }
    }

    class CityInfo {
        public string City { get; set; } //都市
        public int Population { get; set; } //人口
    }
}
