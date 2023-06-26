using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
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

            Console.WriteLine("都市の登録");

            var prefectureDict = new Dictionary<string,List<CityInfo>>();
            Console.Write("県名：");
            var prefecturename = Console.ReadLine();

            while (prefecturename != "999") {
                var cityinfo = new CityInfo();
                Console.Write("所在地：");
                cityinfo.City = Console.ReadLine();
                Console.Write("人口：");
                cityinfo.Population = int.Parse(Console.ReadLine());

                if (prefectureDict.ContainsKey(prefecturename)) {
                    prefectureDict[prefecturename].Add(cityinfo);
                }
                else {
                    prefectureDict[prefecturename] = new List<CityInfo> { cityinfo };
                }
                Console.Write("県名：");
                prefecturename = Console.ReadLine();
            }
            Console.WriteLine("1：一覧表示,2：県名指定");
            Console.Write("＞");
            var judgement = Console.ReadLine();
            if (int.Parse(judgement) == 1) {
                foreach (var s in prefectureDict) {
                    Console.WriteLine("<<<<<{0}>>>>>",s.Key);
                    foreach (var n in s.Value) {
                        Console.WriteLine("{0} {1}人",n.City,n.Population);

                    }
                    Console.WriteLine();
                }
            }
            else if (int.Parse(judgement) == 2) {
                Console.Write("県名：");
                var prefecturename2 = Console.ReadLine();
                Console.WriteLine("<<<<<{0}>>>>>",prefecturename2);
                foreach (var s in prefectureDict[prefecturename2]) {
                    Console.WriteLine("{0}：{1}人", s.City, s.Population);
                }
            }
        }
    }

    class CityInfo {
        public string City { get; set; } //都市
        public int Population { get; set; } //人口
    }
}
