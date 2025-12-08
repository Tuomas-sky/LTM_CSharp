using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_Story_07_MVVM_Self_Command.Controls
{
    public class ColorControlButton:Button,ICommandSource//编写命令源
    {
        // 继承自ICommandSource的三个属性
        // public ICommand Command {  get; set; }
        // public object CommandParameter { get; set; }
        // public IInputElement CommandTarget { get; set; }

        //左键单击触发
        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonUp(e);
            if(this.CommandTarget != null)
            {
                this.Command.Execute(this.CommandTarget);
            }
        }

    }
}
