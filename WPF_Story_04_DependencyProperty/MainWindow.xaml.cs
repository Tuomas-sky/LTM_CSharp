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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Story_04_DependencyProperty
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class Student1:DependencyObject {
        //CLR属性
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //依赖属性
        //注册依赖属性（para1:CLR属性，para2:属性类型，para3:宿主类型，para4():其他功能（包括继承，回调，绑定等），para5:校验功能）
        public static readonly DependencyProperty GradeProperty
            = DependencyProperty.Register("Grade", typeof(int), typeof(Student1));
        //依赖属性包装器
        public int Grade//使用属性封装
        {
            get { return (int)GetValue(GradeProperty); }
            set { SetValue(GradeProperty, value);}
        }
    }

    public class AttachPropertyClass { 
        //通过使用RegisterAttached来注册一个附加属性
        public static readonly DependencyProperty IsAttachedProperty
            =DependencyProperty.RegisterAttached("IaAttached",typeof(bool),typeof(AttachPropertyClass));
         //通过静态方法的形式暴露读操作
        public static bool GetIsAttached(DependencyObject dpo)
        {
            return (bool)dpo.GetValue(IsAttachedProperty);
        }
        public static void SetIsAttached(DependencyObject dpo, bool value)
        {
            dpo.SetValue(IsAttachedProperty, value);
        }

    }

}
