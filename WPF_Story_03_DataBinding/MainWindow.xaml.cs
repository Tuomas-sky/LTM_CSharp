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

namespace WPF_Story_03_DataBinding
{


    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee employee = new Employee() { Name = "default name" };

        ObjectDataProvider odp;
        public MainWindow()
        {
            InitializeComponent();
            //this.InputTextBox.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = employee ,Mode=BindingMode.OneWay});  //data binding 源数据自动更新UI目标数据
            //this.InputTextBox.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = employee ,Mode=BindingMode.TwoWay});  // 双方自动更新 
            //this.InputTextBox.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = employee ,Mode=BindingMode.OneWayToSource});  // 目标自动更新源数据
            //this.InputTextBox.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = employee ,Mode=BindingMode.OneTime});  // 源初始化目标 
            this.SetBinding();
        
        }
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    this.OutputTextBox.Text="my name is "+employee.Name;
        //}
        //private void NameToAmy_Click(object sender, RoutedEventArgs e)
        //{
        //    this.employee.Name = "Amy";
        //}


        private void SetBinding()
        {
           odp = new ObjectDataProvider();
            odp.ObjectInstance = new Calculator();
            odp.MethodName = "Add";
            odp.MethodParameters.Add("0");
            odp.MethodParameters.Add("0");

            Binding bindingPara1 = new Binding("MethodParameters[0]")
            {
                Source = odp,
                Mode = BindingMode.OneWayToSource,
                BindsDirectlyToSource = true,
            };
            Binding bindingPara2 = new Binding("MethodParameters[1]") { 
                Source = odp,
                Mode = BindingMode.OneWayToSource,
                BindsDirectlyToSource = true,
            };

            this.Para1_TextBox.SetBinding(TextBox.TextProperty, bindingPara1);
            this.Para2_TextBox.SetBinding(TextBox.TextProperty, bindingPara2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Outcome_TextBox.Text = odp.Data.ToString();
        }
    }
}
