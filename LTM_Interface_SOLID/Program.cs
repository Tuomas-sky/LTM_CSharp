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

            ////3、依赖反转DIP
            //Customer customer = new Customer();
            //Waiter waiter = new Waiter();
            //customer.Order += waiter.Server;
            //customer.Action();
            //customer.Payfor();

            //4、接口隔离原则
            var wk = new WarmKiller();
            wk.Love();
            //显示调用
            //IKiller killer= wk as IKiller;
            IKiller killer =new WarmKiller();
            killer.Kill();

        }


    }
}
