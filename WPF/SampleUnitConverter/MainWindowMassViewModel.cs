using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowMassViewModel : ViewModel {
        private double grumValue, poundValue;

        //プロパティ
        public double GrumValue {
            get { return this.grumValue; }
            set {
                this.grumValue = value;
                this.OnPropertyChanged();
            }
        }

        public double PoundValue {
            get { return this.poundValue; }
            set {
                this.poundValue = value;
                this.OnPropertyChanged();
            }
        }

        //上のComboBoxで選択されている値（単位）
        public GramUnit CurrentGrumUnit { get; set; }
        //下のComboBoxで選択されている値（単位）
        public PoundUnit CurrentPoundUnit { get; set; }

        //▲ボタンで呼ばれるコマンド
        public ICommand PoundToGrumUnit { get; private set; }
        //▼ボタンで呼ばれるコマンド
        public ICommand GrumToPoundUnit { get; private set; }

        //コンストラクタ
        public MainWindowMassViewModel() {
            this.CurrentGrumUnit = GramUnit.Units.First();
            this.CurrentPoundUnit = PoundUnit.Units.First();

            this.GrumToPoundUnit = new DelegateCommand(
                () => this.PoundValue = this.CurrentPoundUnit.FromGrumUnit(
                    this.CurrentGrumUnit, this.GrumValue));

            this.PoundToGrumUnit = new DelegateCommand(
                () => this.GrumValue = this.CurrentGrumUnit.FromPoundUnit(
                    this.CurrentPoundUnit, this.PoundValue));
        }
    }
}
