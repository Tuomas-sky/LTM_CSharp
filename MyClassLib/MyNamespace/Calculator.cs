using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.MyNamespace
{
    internal class Calculator//被依赖LTM_ClassAndInstance ，在其上添加引用
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
