using Animals.SDK;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace LTM_Reflect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1、接口隔离
            //var car = new Driver(new Car());
            //car.Drive();
            //var tank = new Driver(new LIghtTank());
            //tank.Drive();

            ////2、反射-动态创建对象
            //Car car = new Car();
            //var t = car.GetType();
            //object obj = Activator.CreateInstance(t);
            //MethodInfo mirun = t.GetMethod("Run");
            ////MethodInfo mifire = t.GetMethod("Fire");
            //mirun.Invoke(obj, null);

            //3、依赖注入

            //4、反射加载插件
           // Console.WriteLine(Environment.CurrentDirectory);
           var folder  =Path.Combine(Environment.CurrentDirectory, "Animals");
            var files = Directory.GetFiles(folder);
            var animalsTypes = new List<Type>();
            foreach(var file in files)
            {
                var assembly = Assembly.LoadFrom(file);
                var types = assembly.GetTypes();
                foreach(var t in types)
                {
                    //if (t.GetMethod("Voice") != null)
                    //{
                    //    animalsTypes.Add(t);
                    //}
                    if (t.GetInterfaces().Contains(typeof(IAnimal))
                        )//&& !t.GetCustomAttribute(false).Contains(typeof(UnfinishedAttribute))
                    {
                        animalsTypes.Add(t);
                    }

                }
            }
            while(true)
            {
                for (int i = 0; i < animalsTypes.Count; i++)
                {
                    Console.WriteLine($"{i+1}:{animalsTypes[i].Name}");
                }
                Console.WriteLine("Please select an animal:");
                int index = int.Parse( Console.ReadLine());
                if(index>animalsTypes.Count||index<1)
                {
                    Console.WriteLine("Invalid selection,try again.");
                    continue;
                }
                Console.WriteLine("Please input times:");
                int times = int.Parse( Console.ReadLine());
                var t = animalsTypes[index - 1];
                var m = t.GetMethod("Voice");
                var obj = Activator.CreateInstance(t);
                m.Invoke(obj, new object[] { times });

            }
        }
    }
}
