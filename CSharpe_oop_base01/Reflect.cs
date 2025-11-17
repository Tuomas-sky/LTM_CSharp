using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CSharpe_oop_base01
{

    public class Student1 {
        public int age;
        public string name;

        public int Id { get; set; }
        public double Price { get; set; }

        public void Show() {
            Console.WriteLine("void Show() is called.");
        }
        public string Show2(string name)
        {
            return $"hello,{name}";
        }
    }

    public class Reflect
    {
        public void ReflectOP()
        {
            //1、通过反射的方法，可以遍历成员并调用成员
            object obj = new Student1();
            Type type = obj.GetType();
            Console.WriteLine(type.Name);
            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Namespace);
            Console.WriteLine("=====================");

            //2、method
            //2.1
            //GetFileds():得到所有public的字段
            //GetFiled(String filedname)获取特定字段
            //foreach(var filed in type.GetFields())
            //{
            //    Console.WriteLine(filed.Name);
            //    Console.WriteLine(filed.FieldType.FullName);
            //    if (filed.Name == "age")
            //    {
            //        filed.SetValue(obj, 26);
            //        Console.WriteLine(filed.GetValue(obj));
            //    }
            //    else
            //    {
            //        filed.SetValue(obj, "tom");
            //        Console.WriteLine(filed.GetValue(obj));
            //    }
            //}
            //type.GetField("age").SetValue(obj, 26);
            //Console.WriteLine(type.GetField("age").GetValue(obj));

            ////2.2
            ////GetProperties()获取属性
            //Console.WriteLine("=====================");
            //foreach (var item in type.GetProperties())
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.PropertyType.FullName);
            //    Console.WriteLine(item.PropertyType.Namespace);
            //    //if (item.Name == "Id")
            //    if (item.Name==type.GetProperty("Id").Name)
            //        {
            //        item.SetValue(obj, 26);
            //        Console.WriteLine(item.GetValue(obj));
            //    }
            //}

            ////2.3
            ////GetMethod()
            //Console.WriteLine("=====================");
            ////foreach (var t in type.GetMethods())
            ////{
            ////    Console.WriteLine(t.Name);
            ////}
            ////调用方法
            //type.GetMethod("Show").Invoke(obj, null);
            //var obj_res=type.GetMethod("Show2").Invoke(obj, new object[] {"Tom"});
            //Console.WriteLine(obj_res.ToString());

            //3、使用dll中的方法，动态生成对象
            //Console.WriteLine(Environment.CurrentDirectory+@"\libs\Animals.Lib");
            Console.WriteLine(Environment.CurrentDirectory + @"..\..\libs\Animals.Lib.dll");
            Assembly ass = Assembly.LoadFile(@"D:\Project\CSharpLTM\LTM_ClassAndInstance\CSharpe_oop_base01\libs\Animals.Lib.dll");
            foreach (var t in ass.GetTypes())
            {
                Console.WriteLine(t.Name);
                Console.WriteLine(t.FullName);
                Console.WriteLine(t.IsClass);
            }



        }
    }
}
