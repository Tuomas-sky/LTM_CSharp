using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTM_Interface_SOLID
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////1、紧耦合
            //Engine engine = new Engine();
            //Car car = new Car(engine);
            //car.Run(5);
            //Console.WriteLine(car.Speed);

            ////2、通过interface解耦合
            //var userPhone = new UserPhone(new MotoPhone());
            //userPhone.UsePhone();
            //var userPhone2 = new UserPhone(new XiaomiPhone());
            //userPhone2.UsePhone();

        }
    }
}
