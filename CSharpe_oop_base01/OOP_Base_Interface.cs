using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpe_oop_base01
{
    public class OOP_Base_Interface
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

    //接口--是一个约定规范
    public interface IPerson {
        string Name { get; set; }
        void Eat();
        void SayHi(string name);
    }
    public interface IStudent
    {
        void Study();
    }
    public class Boy : IPerson,IStudent//可以实现多个接口，但是只能继承一个父类
    {
        public string Name { get ; set  ; }

        public void Eat()
        {
            Console.WriteLine($"{Name} 在吃饭。");
        }

        public void SayHi(string name)
        {
            Console.WriteLine($"{Name}在和{name}打招呼。");
        }

        public void PlayGame()
        {
            Console.WriteLine($"{Name} is playing game.");
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is a Student.");
        }
    }



}
