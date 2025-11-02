using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTM_Reflection
{
    internal class Reflection
    {
    }
    //1、反射 reflection
    //反射-以不变应万变（更松的耦合，依赖注入）
    public class Driver
    {
        private IVehical _vehical;
        public Driver(IVehical vehical)
        {
            _vehical = vehical;
        }
        public void Drive()
        {
            _vehical.Run();
        }
    }
    public interface IVehical { 
        void Run();
    }
    public interface IWeapon
    {
        void Fire();
    }
    public interface ITank:IVehical,IWeapon
    {
    }
    public class  Car:IVehical
    {
        public void Run()
        {
            Console.WriteLine("Car is Running...");
        }
    }
    public class AICar : IVehical
    {
        public void Run()
        {
            Console.WriteLine("AICar is Running...");
        }
    }

    public class LIghtTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("LightTank is Firing...");
        }
        public void Run()
        {
            Console.WriteLine("LightTank is Running...");
        }
    }
    public class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("HeavyTank is Firing...");
        }
        public void Run()
        {
            Console.WriteLine("HeavyTank is Running...");
        }
    }

    //2、依赖注入
    




}
