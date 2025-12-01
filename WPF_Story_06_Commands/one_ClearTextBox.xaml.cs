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

namespace WPF_Story_06_Commands
{
    /// <summary>
    /// one_ClearTextBox.xaml 的交互逻辑
    /// </summary>
    public partial class one_ClearTextBox : Window
    {
        public one_ClearTextBox()
        {
            InitializeComponent();
            InitializeCommand();
        }
        //1、声明并定义命令
        private RoutedCommand clearCmd = new RoutedCommand("Clear", typeof(one_ClearTextBox));
        //2、声明命令初始化的方法，包括命令赋值，关联等
        private void InitializeCommand()
        {
            //添加快捷键
            this.clearCmd.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));
            //为命令源指定命令和目标
            this.button.Command = this.clearCmd;
            this.button.CommandTarget = this.textBox;
            //创建命令关联
            CommandBinding cb = new CommandBinding();//创建实例
            cb.Command = this.clearCmd;//指定命令
            cb.CanExecute += new CanExecuteRoutedEventHandler(cb_CanExecute);//订阅相应的事件处理程序
            cb.Executed += new ExecutedRoutedEventHandler(cb_Execute);
            //设置命令关联的位置
            this.stackPanel.CommandBindings.Add(cb);

        }

        //判断事件是否可执行的事件处理器
        private void cb_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(this.textBox.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
            //避免向上执行
            e.Handled=true;
        }
        //命令达到目标后要执行的事件处理器
        private void cb_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            this.textBox.Clear();
            e.Handled = true;
        }

    }
}
