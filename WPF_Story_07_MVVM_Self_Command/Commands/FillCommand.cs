using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WPF_Story_07_MVVM_Self_Command.Commands
{
    public partial class FillCommand : ICommand
    {
        //当命令可执行状态发生改变，应该被激发
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        //用于接收设定的CommandParameter参数
        string hex;
        public string Hex
        {
            get { return hex; }
            set { hex = value; }
        }

        public bool CanExecute(object parameter)
        {
            //如果参数是一个有效的十六进制颜色值，则命令可以执行
            if(parameter is string hexColor)
            {
                return hexColor.StartsWith("#") && (hexColor.Length == 7 );
            }
            return false;
        }
        //执行命令的逻辑
        public void Execute(object parameter)
        {
            if(parameter is string p)
            {
                Hex = parameter.ToString();
            }
            IColorable colorable = parameter as IColorable;
            if(colorable != null)
            {
                try
                {
                    Color color = (Color)ColorConverter.ConvertFromString(Hex);
                    colorable.Fill(color);
                }
                catch (Exception)
                {

                    // 如果转换失败，显示错误信息
                    MessageBox.Show("不合法的HEX值", "Invalid color", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }


        }
    }
}
