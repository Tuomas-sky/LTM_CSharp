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

namespace WPF_Story_05_RoutingEventsAndCommand
{
    /// <summary>
    /// RouteEvent.xaml 的交互逻辑
    /// </summary>
    public partial class RouteEvent : Window
    {
        //系统自带路由事件
        public RouteEvent()
        {
            InitializeComponent();
            this.leftCanvas.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.ButtonClicked));
            this.baseGrid.AddHandler(Button.ClickEvent,new RoutedEventHandler(this.ButtonClicked));
        }
        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            Button button = e.OriginalSource as Button;
            if (button!=null)
            {
                MessageBox.Show("You Clicked on Button " + button.Content);
                //将路由事件标记为已处理,前面逻辑只执行一次
                e.Handled = true;
            }
        }
    }
}
