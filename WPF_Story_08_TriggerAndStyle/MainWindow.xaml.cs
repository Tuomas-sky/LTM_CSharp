using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPF_Story_08_TriggerAndStyle
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeUniversityList();
        }
        private void InitializeUniversityList()
        {
            List<University> universities = new List<University>()
            {
                new University(){ Name="Tsinghua University", Country="China", Established="1911", Sketch="Public universities within Beijing, China"},
                new University(){ Name="Peking University", Country="China", Established="1898", Sketch="Public universities within Beijing, China"},
            };
            this.listBoxUniversity.ItemsSource = universities;
        }
    }
}
