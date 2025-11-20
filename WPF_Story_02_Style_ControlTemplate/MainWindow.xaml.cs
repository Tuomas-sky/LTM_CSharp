using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WPF_Story_02_Style_ControlTemplate
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CS1_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["PresetColor_1"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#05E0E9"));
            this.Resources["PresetColor_2"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#878787"));
        }
        private void CS2_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["PresetColor_1"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#64CD28"));
            this.Resources["PresetColor_2"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));

        }
    }
}
