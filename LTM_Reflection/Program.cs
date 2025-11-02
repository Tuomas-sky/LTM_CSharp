using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LTM_Reflection
{
    public class Program
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
            


        }

    }
}
