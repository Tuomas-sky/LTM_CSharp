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
    public class FillCommand : ICommand
    {
        //事件：当命令的可执行状态发生改变时，应该被激发
        public event EventHandler CanExecuteChanged
        {
            add{ CommandManager.RequerySuggested += value; }
            remove {  CommandManager.RequerySuggested -= value;}
        }
        //用于接收设定的CommandParameter的属性
        string hex;
        public string Hex { get => hex; set => hex = value; }
        public bool CanExecute(object parameter)
        {
            if(parameter is string h)
            {
                return h.StartsWith("#") && h.Length == 7;
            }
            return false;
        }
        //执行命令，带有与业务相关的Fill逻辑
        public void Execute(object parameter)
        {
           if(parameter is string p)
            {
                Hex = parameter.ToString();
            }
           IColorable colorable=parameter as IColorable;
            if (colorable != null)
            {
                //尝试将命令参数转换为颜色
                try
                {
                    Color color = (Color)ColorConverter.ConvertFromString(Hex);
                    colorable.Fill(color);
                }
                catch (Exception ex) {
                    // 如果转换失败，显示错误信息
                    MessageBox.Show("不合法的HEX值", "Invalid color", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
