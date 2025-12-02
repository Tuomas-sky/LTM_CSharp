using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_Story_07_MVVM_Self_Command
{
    //约束接口
    public interface IColorable
    {
        Color CurrentColor { get; set; }

        void Clear();

        void Fill(Color color);
    }
}
