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

namespace WPF_Story_05_RoutingEvent
{
    /// <summary>
    /// Custom_RouteEvent.xaml 的交互逻辑
    /// </summary>
    public partial class Custom_RouteEvent : Window
    {
        public Custom_RouteEvent()
        {
            InitializeComponent();
        }

        private void ReportTimeHandler(object sender, ReportTimeEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            string timeStr = e.ClickTime.ToString();
            string content = string.Format("时间：{0}；元素：{1}", timeStr, element.Name);
            this.ListBox.Items.Add(content);
        }
       
    }
    //1、先定义一个用于承载当前时间的类作为事件参数，该类继承于RoutedEventArgs类。
    public class ReportTimeEventArgs : RoutedEventArgs
    {
        public ReportTimeEventArgs(RoutedEvent e, object source) : base(e, source)
        { }

        public DateTime ClickTime { get; set; }//存储路由事件触发时的时间
    }
    //2、编写自定义按钮，其功能均与Button相同，只是要添加自定义路由事件，故直接继承Button类即可
    public class TimeButton : Button
    {
        //①声明和注册路由事件
        //public delegate void ReportTimeEventHandler(object sender, ReportTimeEventArgs e);
        //public static readonly RoutedEvent ReportEventTime = 
        //    EventManager.RegisterRoutedEvent("ReportTime",RoutingStrategy.Bubble,typeof(ReportTimeEventHandler),typeof(TimeButton));
        //或者
        public static readonly RoutedEvent ReportTimeEvent =
            EventManager.RegisterRoutedEvent("ReportTime", RoutingStrategy.Bubble, typeof(EventHandler<ReportTimeEventArgs>), typeof(TimeButton));

        //②CLR事件包装器
        public event RoutedEventHandler ReportTime
        {
            add { this.AddHandler(ReportTimeEvent, value); }
            remove { this.RemoveHandler(ReportTimeEvent, value); }
        }

        //③重写OnClick方法，编写事件的激发逻辑
        protected override void OnClick()
        {
            base.OnClick();
            //1.实例化路由事件参数实例并关联路由事件；
            //2.为路由事件参数的成员赋值；
            //3.使用RaiseEvent方法引发路由事件，并传递事件参数实例作为参数。
            ReportTimeEventArgs args = new ReportTimeEventArgs(ReportTimeEvent, this);
            args.ClickTime = DateTime.Now;
            this.RaiseEvent(args);
        }

    }



}
