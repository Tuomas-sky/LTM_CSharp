using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    internal class Generic
    {
    }


    //1.泛型类
    public class Apple {
        public string Color { get; set; }
    }

    public class  Book
    {
        public string Name { get; set; }
    }
    public class Box<TCargo>
    {
        public TCargo Cargo { get; set; }
    }

    //2.泛型接口
    interface IUnique<TId> { 
        TId Id { get; set; }
    }
    public class Student1<TId>: IUnique<TId>//实现泛型接口,Student1本身是泛型类
    {
        public TId Id { get; set; }
        public string Name { get; set; }
    }
    public class Student2: IUnique<int>//实现非泛型接口，Student2本身不是泛型类
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //3.泛型方法
    //4.泛型委托 Action & Func
    public class GenericMethod
    {
       public void ShowMsg(string msg)
        {
            Console.WriteLine("hello {0}",msg);
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }

}
