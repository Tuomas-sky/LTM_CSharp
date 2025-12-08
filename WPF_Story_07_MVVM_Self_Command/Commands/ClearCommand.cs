using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Story_07_MVVM_Self_Command.Commands
{
    public class ClearCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            IColorable colorable =parameter as IColorable;
            if (colorable != null) { 
                colorable.Clear();
            }
        }

    }
}
