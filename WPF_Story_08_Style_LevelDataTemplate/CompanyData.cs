using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Story_08_Style_LevelDataTemplate
{
    public class CompanyData
    {
        public string Name {  get; set; }
        public List<DepartmentData> DepartmentDatas { get; set; }

    }
    public class DepartmentData
    {
        public string Name { get; set; }
        public List<EmployeeData> EmployeeDatas { get; set; }
    }
    public class EmployeeData {
        public string Name { get; set; }
    }

}
