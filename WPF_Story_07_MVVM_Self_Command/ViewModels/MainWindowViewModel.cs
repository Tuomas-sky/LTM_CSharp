using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Story_07_MVVM_Self_Command.Commands;

namespace WPF_Story_07_MVVM_Self_Command.ViewModels
{
    public class MainWindowViewModel
    {
        public ICommand ClearCommand {  get; set; }
        public ICommand FillCommand { get; set; }
        public MainWindowViewModel() { 
            this.ClearCommand=new ClearCommand();
            this.FillCommand=new FillCommand();
        }
    }
}
