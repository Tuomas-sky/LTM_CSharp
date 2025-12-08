using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_Story_07_MVVM_Self_Command
{
    public interface IColorable
    {
        Color CurrentColor { get; set; }

        void Fill(Color color);
        void Clear();

    }
}
