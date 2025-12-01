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
using System.Windows.Shapes;


//路由事件：为了实现事件在元素树中的传播
//附加事件：为了让实现界面上不可见的类与其他控件之间进行通信
namespace WPF_Story_05_RoutingEvent
{

    //为自定义类添加附加事件
    public class Staff {
        public String Name { get; set; }
        public double Salary { get; set; }

        //1、attached event
        public static readonly RoutedEvent SalaryChangedEvent
            = EventManager.RegisterRoutedEvent("SalaryChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Staff));
        //2、额外编写两个访问器方法，用于添加侦听和移除侦听
        //一是事件的监听者，类型为DependencyObject，二是事件的处理器，类型为RoutedEventHandler委托类型
       //第一借
        public static void AddSalaryChangedHandler(DependencyObject d,RoutedEventHandler h)
        {
            UIElement uie = d as UIElement;
            if (uie!=null)
            {
                uie.AddHandler(Staff.SalaryChangedEvent, h);
            }
        }
        public static void RemoveSalaryChangedHandler(DependencyObject d,RoutedEventHandler h)
        {
            UIElement uie = d as UIElement;
            if (uie != null)
            {
                uie.RemoveHandler(Staff.SalaryChangedEvent, h);
            }
        }


    }



    /// <summary>
    /// AttachEvent.xaml 的交互逻辑
    /// </summary>
    public partial class AttachEvent : Window
    {
        public AttachEvent()
        {
            InitializeComponent();
            //最外层gird实现侦听
            Staff.AddSalaryChangedHandler(this.BaseGrid, new RoutedEventHandler(StaffSalaryChangedHandler));
            //this.BaseGrid.AddHandler(Staff.SalaryChangedEvent,new RoutedEventHandler(this.StaffSalaryChangedHandler));
        }

        //使用按钮触发事件，进行路由传递
        private void AttachButton_Click(object sender, RoutedEventArgs e)
        {
            Staff staff = new Staff() { Name="Tom",Salary=8888};
            staff.Salary = 9999;
            //第二借借助button将附加事件进行路由传递
            RoutedEventArgs args = new RoutedEventArgs(Staff.SalaryChangedEvent,staff);
            this.AttachButton.RaiseEvent(args);
        }
        //监听者监听到事件后的事件处理程序
        private void StaffSalaryChangedHandler(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as Staff).Name.ToString() + " 的Salary改变了！");
        }


    }
}
