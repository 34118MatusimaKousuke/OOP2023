using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorCheaker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
            ColorData.DataContext = GetColorList();
        }



        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

            SolidColorBrush solidColorBrush = new SolidColorBrush();

            solidColorBrush.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            colorArea.Background = solidColorBrush;

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            SolidColorBrush solidColorBrush = new SolidColorBrush();

            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;

            solidColorBrush.Color = mycolor.Color;
            colorArea.Background = solidColorBrush;
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }
        List<MyColor> myColors = new List<MyColor>();

        public class StackColor {
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }

        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            var colorlist = GetColorList();

            var color = String.Format("R {0} B {1} G {2}", rSlider.Value, gSlider.Value, bSlider.Value);

            var c = colorlist.FirstOrDefault(x => x.Color == ((SolidColorBrush)colorArea.Background).Color)?.Name??color;

            MyColor aaa = new MyColor{ Color = ((SolidColorBrush)colorArea.Background).Color, Name = c };

            myColors.Add(aaa);
            stockList.Items.Add(aaa.Name);
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var colorlist = GetColorList();

            foreach (var s in colorlist) {
                if (stockList.SelectedItem.ToString() == s.Name) {
                    rValue.Text = s.Color.R.ToString();
                    gValue.Text = s.Color.G.ToString();
                    bValue.Text = s.Color.B.ToString();
                }
            }
            string[] Stock = stockList.SelectedItem.ToString().Split(' ');

            if (Stock.Length > 4) {
                rValue.Text = Stock[1];
                gValue.Text = Stock[3];
                bValue.Text = Stock[5];
            }
        }
    }
}
