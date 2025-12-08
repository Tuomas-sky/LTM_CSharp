using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_Story_07_MVVM_Self_Command.Controls
{
    public class ColorBorder : Border, IColorable
    {
        //当前颜色属性及依赖属性
        public Color CurrentColor
        {
            get { return (Color)GetValue(CurrentColorProperty); }
            set { SetValue(CurrentColorProperty,value); }
        }
        public static readonly DependencyProperty CurrentColorProperty
            = DependencyProperty.Register("CurrentColor", typeof(Color), typeof(ColorBorder), new PropertyMetadata(Colors.Transparent));

        //清除颜色设置为透明
        public void Clear()
        {
            this.CurrentColor = Colors.Transparent;
            this.Background=Brushes.Transparent;
        }

        //设置当前颜色
        public void Fill(Color color)
        {
            this.CurrentColor = color;
            this.Background = new SolidColorBrush(color);
        }
    }
}
