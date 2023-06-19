using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }

        //科目別の点数を求める  
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new SortedDictionary<string, int>();
            foreach (Student student in _score) {
                if (dict.ContainsKey(student.Subject))
                    dict[student.Subject] += student.Score;　//科目名が既に存在する(点数加算)
                else
                    dict[student.Subject] = student.Score; //科目名が存在しない(新規格納)
            }
            return dict;
        }
        //学生データを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            var scores = new List<Student>(); //学生データを格納
            var lines = File.ReadAllLines(filePath); //ファイルからすべてのデータ読みこむ
            foreach (var line in lines) { //すべての行から一行ずつ取り出す
                var items = line.Split(','); //区切りで項目別に分ける
                var student = new Student { //Studentインスタンスを作成
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2]),
                };
                scores.Add(student); //Studentインスタンスをコレクションに追加
            }
            return scores;
        }
    }
}






