using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Song {

        //歌のタイトル
        public string Title { get; set; }

        //アーティスト名
        public string ArtistName { get; set; }

        //演奏時間
        public int Length { get; set; }

        public Song(string title, string artistName, int Length) {
            Title = title;
            ArtistName = artistName;
            Length = Length;
    }

}
