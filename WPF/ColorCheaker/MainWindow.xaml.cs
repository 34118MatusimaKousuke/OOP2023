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

        private void stockButton_Click(object sender, RoutedEventArgs e) {

            var color = new StackColor() {
                R = (int)rSlider.Value,
                G = (int)gSlider.Value,
                B = (int)bSlider.Value
            };
            stockList.Items.Add("R:" + color.R + "G:" + color.G + "B:" + color.B);

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

        public class StackColor {
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }

        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }
    }
}
