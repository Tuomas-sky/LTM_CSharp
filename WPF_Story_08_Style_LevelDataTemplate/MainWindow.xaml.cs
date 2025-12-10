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
using System.Xml;

namespace WPF_Story_08_Style_LevelDataTemplate
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //InitializeList();
        }

        private void InitializeList()
        {
            EmployeeData emp1 = new EmployeeData { Name = "Lucy" };
            EmployeeData emp2 = new EmployeeData() { Name = "Linda" };
            EmployeeData emp3 = new EmployeeData() { Name = "Amy" };
            EmployeeData emp4 = new EmployeeData() { Name = "King" };

            DepartmentData de1 = new DepartmentData()
            {
                Name = "Technology Department",
                EmployeeDatas=new List<EmployeeData> { emp1, emp2 }
            };
            DepartmentData de2 = new DepartmentData()
            {
                Name = "Finance Department",
                EmployeeDatas = new List<EmployeeData> { emp3, emp4 }
            };

            CompanyData company1 = new CompanyData()
            {
                Name = "Default Company",
                DepartmentDatas=new List<DepartmentData> { de1, de2 }
            };

            List<CompanyData> data=new List<CompanyData>();
            data.Add(company1);
            //this.treeView.ItemsSource=data;

        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mi=e.OriginalSource as MenuItem;
            XmlElement xe = mi.Header as XmlElement;
            MessageBox.Show(xe.Attributes["Name"].Value);
        }
    }
}
