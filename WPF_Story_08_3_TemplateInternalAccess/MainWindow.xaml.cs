using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

namespace WPF_Story_08_3_TemplateInternalAccess
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

        private T FindVisualChild<T>(DependencyObject parent) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);
                if (child is T)
                {
                    return (T)child;
                }
                else
                {
                    T childOfChild = FindVisualChild<T>(child);
                    if (childOfChild != null)
                    {
                        return childOfChild;
                    }
                }
            }
            return null;
        }

        private T FindVisualChild<T>(DependencyObject parent,string ControlName) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);
                if (child is T && child.GetValue(FrameworkElement.NameProperty).ToString()==ControlName)
                {
                    return (T)child;
                }
                else
                {
                    T childOfChild = FindVisualChild<T>(child,ControlName);
                    if (childOfChild != null)
                    {
                        return childOfChild;
                    }
                }
            }
            return null;
        }

        private void listViewEmp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person person = (this.listViewEmp.SelectedItem)as Person;
            ListViewItem lvi = this.listViewEmp.ItemContainerGenerator.ContainerFromItem(person) as ListViewItem;

            TextBox tbx_B = this.FindVisualChild<TextBox>(lvi);
            MessageBox.Show(tbx_B.Text);

            //查找特定字段，指定控件
            TextBlock tbk = this.FindVisualChild<TextBlock>(lvi, "textBlock_Birthday");
            MessageBox.Show(tbk.Text);

        }

        //ControlTemplate
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    TextBox tbx = this.uc.Template.FindName("textBox",this.uc) as TextBox;
        //    Slider sld = uc.Template.FindName("slider",uc) as Slider;
        //    StackPanel sp = tbx.Parent as StackPanel;

        //    tbx.Text = "6";
        //    sld.Value = 6;
        //    (sp.Children[2] as TextBlock).Text = "Show value=6";
        //}
    }
}
