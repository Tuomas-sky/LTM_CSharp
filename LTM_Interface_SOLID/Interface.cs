using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTM_Interface_SOLID
{
    public class Interface
    {
    }

    //1、紧耦合
    public class  Engine
    {
        public int RPM { get; set; }
        public void Work(int gas)
        {
            this.RPM = gas*1000;
        }
    }
    public class Car
    {
        private Engine _engine;
        public Car(Engine engine)
        {
            this._engine=engine;
        }
        public int Speed { get; set; }
        public void Run(int gas)
        {
            this._engine.Work(gas);
            this.Speed = _engine.RPM / 100;
        }
    }
    //2、通过interface解耦合
    public interface IPhone {
        void Call();
        void CallUp();
        void Send();
        void Receive();
    }
    public class MotoPhone : IPhone
    {
        public void Call()
        {
            Console.WriteLine("Moto call...");
        }

        public void CallUp()
        {
            Console.WriteLine("Moto CallUp...");
        }

        public void Receive()
        {
            Console.WriteLine("Moto Receive...");
        }

        public void Send()
        {
            Console.WriteLine("Moto Send...");
        }
    }
    public class  XiaomiPhone:IPhone
    {
        public void Call()
        {
            Console.WriteLine("Xiaomi call...");
        }
        public void CallUp()
        {
            Console.WriteLine("Xiaomi CallUp...");
        }
        public void Receive()
        {
            Console.WriteLine("Xiaomi Receive...");
        }
        public void Send()
        {
            Console.WriteLine("Xiaomi Send...");
        }
    }
    public class UserPhone { 
        private IPhone _iphone;
        public UserPhone(IPhone phone)
        {
            _iphone = phone;
        }
        public void UsePhone()
        {
            _iphone.Call();
            _iphone.CallUp();
            _iphone.Send();
            _iphone.Receive();
        }
    }

    //3、依赖反转DIP
    public class OrderEventArgs : EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }
    //public delegate void OrderEventHandler(Customer customer,OrderEventArgs orderEventArgs);
    public class Customer {

        //private OrderEventHandler _orderEventHandler;
        //public event OrderEventHandler Order
        //{
        //    add
        //    {
        //        _orderEventHandler += value;
        //    }
        //    remove
        //    {
        //        _orderEventHandler -= value;
        //    }
        //}
        //①简化写法
        //public event OrderEventHandler Order;

        //③系统自带
        public event EventHandler Order;
        public double Bill { get; set; }

        public void WalkIn()
        {
            Console.WriteLine("Customer walk in restaurant.");
        }
        public void Think()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Think...");
                System.Threading.Thread.Sleep(1000);
            }
            //if(_orderEventHandler!=null)
            //{
            //    OrderEventArgs orderEventArgs = new OrderEventArgs()
            //    {
            //        DishName="Noodle",
            //        Size="large"
            //    };
            //    _orderEventHandler(this, orderEventArgs);
            //}
            //①简化写法
            //if(Order!=null)
            //{
            //    OrderEventArgs orderEventArgs = new OrderEventArgs()
            //    {
            //        DishName = "Noodle",
            //        Size = "large"
            //    };
            //    Order(this, orderEventArgs);
            //}
            //② 常用写法
            OnOrder("Noodle","large");

        }
        public void OnOrder(string dishName,string size)
        {
            if (Order != null)
            {
                OrderEventArgs orderEventArgs = new OrderEventArgs();
                orderEventArgs.DishName = dishName;
                orderEventArgs.Size = size;
                Order(this, orderEventArgs);
            }
        }
        public void Action()
        {
            WalkIn();
            Think();
        }
        public void Payfor()
        {
           Console.WriteLine("Customer pay for -$"+Bill.ToString());
        }


    }
    public class Waiter
    {
        //public void Server(Customer customer, OrderEventArgs orderEventArgs)
        public void Server(Object sender, EventArgs e)
        {
            Customer customer = sender as Customer;
            OrderEventArgs orderEventArgs = e as OrderEventArgs;
            Console.WriteLine("I will server you dish - "+orderEventArgs.DishName);
            double price = 20;
            switch (orderEventArgs.Size)
            {
                case "large":
                    price *= 1.5;
                    break;
                case "samll":
                    price *= 0.5;
                    break;
                default:
                    break;
            }
            customer.Bill += price;
            Console.WriteLine("you will pay for -$"+price.ToString());
        }
    }

    //4、接口隔离原则
    interface IGentleman
    {
        void Love();
    }
    interface IKiller
    {
        void Kill();
    }
    public class WarmKiller : IGentleman, IKiller
    {
        public void Love()
        {
            Console.WriteLine("I love you！");
        }

        void IKiller.Kill()
        {
            Console.WriteLine("I will kill you!");
        }
    }


}
