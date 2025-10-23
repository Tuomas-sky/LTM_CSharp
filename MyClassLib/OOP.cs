using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class OOP
    {
    }
    //is a 是一个，表示继承关系，子类对象是父类对象的一种特殊类型，返回为bool类型

    //可见的签名一致的函数成员
#if false
    public class Vehical
    {
        //继承访问修饰符：private、protected、internal、protected internal、public
        internal string Ownner { get { return "N/A"; } }
        private int _fuel;
        protected int _rpm;
        public void Refuel(int fuel) { _fuel += fuel; }
        public void Burn(int fuel) { _fuel -= fuel; }
        public void Acculerate() { 
            Burn(1);
            _rpm += 1000;
        }
        public int Speed { get { return _rpm / 100; } }
        //-------------------------------------------------------------------------------
        //子类添加新成员-成员个数增加-横向
        //重写-版本扩展-纵向
        private int _poloSpeed;
        public virtual int PolySpeed { 
            get { return _poloSpeed; }
            set { _poloSpeed = value; }
        }
        public virtual void Run()//virtual名存实亡
        {
            Console.WriteLine("Vehical is running");
            _poloSpeed = 100;
        }
        

    }
    public class Car : Vehical { 
        public void ShowOwner()
        {
            Console.WriteLine($"The owner of this car is {Ownner}");
        }

        public void TurboAcc()
        {
            Burn(2);
            _rpm += 3000;
        }

        //-------------------------------------------------------------------------------
        //重写-版本扩展-纵向
        //不加 override 会报错，提示隐藏基类方法，建议加new关键字,子类对父类的隐藏
        //public void Run()
        //{
        //  Console.WriteLine("Car is running fast");
        //}
        private int _poloRpm    ;
        public override int PolySpeed
        {
            get { return _poloRpm / 100; }
            set { _poloRpm = value * 100; }
        }
        public override void Run()
        {
            Console.WriteLine("Car is running");
            _poloRpm = 5000;
        }
    }

    public class RaceCar : Car { }
#endif

    //interface接口
    interface IVehical { 
        void Run();
        void Stop();
        void Refuel();
    }
    public abstract class Vehical: IVehical
    {
        public void Refuel()
        {
            Console.WriteLine("Pay and Refuel");
        }
        public void Stop()
        {
            Console.WriteLine("Stopped!");
        }
        public abstract void Run();//抽象方法没有方法体，必须在子类中重写

    }
    public class Car : Vehical
    {
        public override void Run()
        {
            Console.WriteLine("Car is running");
        }
    }
    public class Bus : Vehical
    {
        public override void Run()
        {
            Console.WriteLine("Bus is running");
        }
    }



}
