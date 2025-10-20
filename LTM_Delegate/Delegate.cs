using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTM_Delegate
{
    internal class Delegate//委托是一种类型，表示对具有特定参数列表和返回类型的方法的引用
    {
    }

    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 methods");
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    //委托
#if true
    //1.1委托--模板方法
    //class Product {
    //    public string Name { get; set; }
    //}
    //class Box
    //{
    //    public Product Product { get; set; }
    //}
    //class WarpFactory
    //{
    //    public Box WarpProdect(Func<Product> getProduct)
    //    {
    //        Box box = new Box();
    //        //box.Product = getProduct();
    //        Product product = getProduct();
    //        box.Product = product;
    //        return box;
    //    }
    //}
    //class ProductFactory
    //{
    //    public Product MakePizza()
    //    {
    //        Product product = new Product();
    //        product.Name = "Pizza";
    //        return product;
    //    }
    //    public Product MakeToy()
    //    {
    //        Product product = new Product();
    //        product.Name = "Toy";
    //        return product;
    //    }
    //}

    ////1.2委托--回调函数
    //class Logger
    //{
    //    public void Log(Product product)
    //    {
    //        Console.WriteLine("Log message:Product Name is {0},Created at {1},Price is {2}",product.Name,DateTime.UtcNow,product.Prize );
    //    }
    //}
    //class Product
    //{
    //    public string Name { get; set; }
    //    public double Prize { get; set; }
    //}
    //class Box
    //{
    //    public Product Product { get; set; }
    //}
    //class WarpFactory
    //{
    //    public Box WarpProdect(Func<Product> getProduct,Action<Product> logCallback)
    //    {
    //        Box box = new Box();
    //        //box.Product = getProduct();
    //        Product product = getProduct();
    //        if (product.Prize > 50)
    //        {
    //            logCallback(product);
    //        }
    //        box.Product = product;
    //        return box;
    //    }
    //}
    //class ProductFactory
    //{
    //    public Product MakePizza()
    //    {
    //        Product product = new Product();
    //        product.Name = "Pizza";
    //        product.Prize = 25.0;
    //        return product;
    //    }
    //    public Product MakeToy()
    //    {
    //        Product product = new Product();
    //        product.Name = "Toy";
    //        product.Prize = 100.0;
    //        return product;
    //    }
    //}

    interface IProductFactory
    {
        Product MakeProduct();
    }
    class PizzaFactory : IProductFactory
    {
        public Product MakeProduct()
        {
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }
    }
    class ToyFactory : IProductFactory
    {
        public Product MakeProduct()
        {
            Product product = new Product();
            product.Name = "Toy";
            return product;
        }
    }
    class Product
    {
        public string Name { get; set; }
    }
    class Box
    {
        public Product Product { get; set; }
    }
    class WarpFactory
    {
        public Box WarpProdect(IProductFactory productFactory)
        {
            Box box = new Box();
            //box.Product = getProduct();
            Product product = productFactory.MakeProduct();
            box.Product = product;
            return box;
        }
    }


#endif



        //2.多播委托
        class StudentPen
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomework()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student {0} is doing homework {1} hour(s).", ID, i + 1);
                Thread.Sleep(500);
            }
        }
    }



}
