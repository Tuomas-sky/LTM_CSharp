using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpe_oop_base01
{
    public class OOP_Base
    {
       public void OOP_Value_Ref()
        {
            string s1 = "abc";
            string s2 = "abc";
            Console.WriteLine(Object.ReferenceEquals(s1, s2));//true
            s2 += "def";//会修改地址
            Console.WriteLine(Object.ReferenceEquals(s1, s2));//false




        }
    }
}
