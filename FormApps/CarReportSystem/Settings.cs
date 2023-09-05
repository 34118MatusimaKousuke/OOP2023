using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    //設定情報
    public class Settings {
        private static Settings instsnce;

        public int MainFormColor { get; set; }

        private Settings() { }

        static public Settings getInstance() {
            if (instsnce == null) {
                instsnce = new Settings();
            }
            return instsnce;
        }
    }
}
