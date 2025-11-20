using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Story_03_DataBinding
{
    public class Calculator
    {
        public string Add(string para1,string para2)
        {
            double arg1 = 0;
            double arg2 = 0;
            double res = 0;
            if(double.TryParse(para1,out arg1)&&double.TryParse(para2,out arg2))
            {
                res = arg1 + arg2;
                return res.ToString();
            }
            else
            {
                return "error input!";
            }
        }
    }
}
