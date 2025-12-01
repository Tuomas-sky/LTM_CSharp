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
using System.Windows.Shapes;

namespace WPF_Story_06_Commands
{
    /// <summary>
    /// two_CommandPrameter.xaml 的交互逻辑
    /// </summary>
    public partial class two_CommandPrameter : Window
    {
        public two_CommandPrameter()
        {
            InitializeComponent();
        }

        private void New_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.nameTextBox.Text) || string.IsNullOrEmpty(this.ageTextBox.Text))
            {
                e.CanExecute = false;
            }
            else { 
                e.CanExecute=true;
            }

        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string name = this.nameTextBox.Text;
            string age = this.ageTextBox.Text;
            if (e.Parameter.ToString() == "Teacher")
            {
                this.listBoxNewItem.Items.Add(string.Format("Teacher | Name: {0};Age:{1}", name, age));
            }
            if(e.Parameter.ToString() == "Student")
            {
                this.listBoxNewItem.Items.Add(string.Format("Student | Name: {0},Age: {1}", name, age));
            }
        }
    }
}
