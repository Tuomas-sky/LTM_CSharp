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


}
