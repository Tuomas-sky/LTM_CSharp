using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTM_Delegate
{
    //声明委托
    delegate int Calc(int a, int b);
    //    委托的一般使用
    //1.实例：把方法当作参数传给另一个方法
    //正确使用1：模板方法，"借用"指定的外部方法来产生结果
    //相当于"填空题"
    //常位于---代码中部
    //委托有返回值
    //正确使用2：回调（callback）方法，调用指定的外部方法
    //相当于"流水线”
    //常位于---代码末尾
    //委托无返回值
    //2.注意：难精通+易使用+功能强大东西，一旦被滥用则后果非常严重
    //缺点1：这是一种方法级别的紧耦合，现实工作中要慎之又慎
    //缺点2：使可读性下降、debug的难度增加
    //缺点3：把委托回调、异步调用和多线程纠缠在一起，会让代码变得难以阅读和维护
    //缺点4：委托使用不当有可能造成内存泄漏和程序性能下降
    internal class Program
    {
        static string ProcessData(string str, Func<string, string> func1, Func<string, string> func2)
        {
            return func2(func1(str));
        }
        static void Main(string[] args)
        {

            //1. delegate Action和Func
            //Calculator calculator = new Calculator();
            //calculator.Report();//直接调用
            //Action action = new Action(calculator.Report);//无参数无返回值
            //action();//间接调用
            //Func<int,int,int> funcAdd = new Func<int, int, int>(calculator.Add);//有参数有返回值
            //int result = funcAdd(10, 20);
            //Console.WriteLine("funcAdd: result={0}",result);
            //Type t = typeof(Action);
            //Console.WriteLine("Action is class? result={0}",t.IsClass);

            //2. 使用自定义委托
            //Calculator c = new Calculator();
            //Calc calc = new Calc(c.Add);
            //int result = calc(100, 200);
            //Console.WriteLine("funcAdd: result={0}", result);

            ////3.1 把方法当作参数传给另一个方法---模板函数
            //WarpFactory warpFactory = new WarpFactory();
            //ProductFactory productFactory = new ProductFactory();
            ////包装披萨
            //Func<Product> pizza = new Func<Product>(productFactory.MakePizza);
            //Box pizzaBox = warpFactory.WarpProdect(pizza);
            //Box toyBox = warpFactory.WarpProdect(productFactory.MakeToy);
            //Console.WriteLine(pizzaBox.Product.Name);
            //Console.WriteLine(toyBox.Product.Name);
            //Console.WriteLine("-------------------");
            ////3.2 把方法当作参数传给另一个方法---回调函数
            //WarpFactory warpFactory = new WarpFactory();
            //ProductFactory productFactory = new ProductFactory();
            //Logger logger = new Logger();
            ////包装披萨
            //Box pizzaBox = warpFactory.WarpProdect(productFactory.MakePizza,logger.Log);
            //Box toyBox = warpFactory.WarpProdect(productFactory.MakeToy,logger.Log);
            //Console.WriteLine(pizzaBox.Product.Name);
            //Console.WriteLine(toyBox.Product.Name);
            //Console.WriteLine("-------------------");
            ////3.3 使用接口简化回调函数的使用（不使用委托）
            //WarpFactory warpFactory = new WarpFactory();
            //IProductFactory pizzaFactory = new PizzaFactory();
            //IProductFactory toyFactory = new ToyFactory();
            //Box pizzaBox = warpFactory.WarpProdect(pizzaFactory);
            //Box toyBox = warpFactory.WarpProdect(toyFactory);
            //Console.WriteLine(pizzaBox.Product.Name);
            //Console.WriteLine(toyBox.Product.Name);

            ////4.多播委托
            //StudentPen stu1 = new StudentPen() { ID = 1, PenColor = ConsoleColor.Red };
            //StudentPen stu2 = new StudentPen() { ID = 2, PenColor = ConsoleColor.Green };
            //StudentPen stu3 = new StudentPen() { ID = 3, PenColor = ConsoleColor.Blue };
            //Action action1 = new Action(stu1.DoHomework);
            //Action action2 = new Action(stu2.DoHomework);
            //Action action3 = new Action(stu3.DoHomework);
            //action1 += action2;
            //action1+=action3;
            //action1();

            ////5.3种同步调用，直接调用stu1.DoHomework()、委托调用 action1()、多播委托调用action1+=action2+=action3
            //StudentPen stu1 = new StudentPen() { ID = 1, PenColor = ConsoleColor.Red };
            //StudentPen stu2 = new StudentPen() { ID = 2, PenColor = ConsoleColor.Green };
            //StudentPen stu3 = new StudentPen() { ID = 3, PenColor = ConsoleColor.Blue };
            ////stu1.DoHomework();
            ////stu2.DoHomework();
            ////stu3.DoHomework();
            //Action action1 = new Action(stu1.DoHomework);
            //Action action2 = new Action(stu2.DoHomework);
            //Action action3 = new Action(stu3.DoHomework);

            ////6.1 3种异步调用，BeginInvoke隐式异步调用，Thread & Task显示异步调用
            ////action1.BeginInvoke(null, null);
            ////action2.BeginInvoke(null, null);
            ////action3.BeginInvoke(null, null);
            ////6.2 Thread方式多线程调用
            ////Thread th1 = new Thread(new ThreadStart(stu1.DoHomework));
            ////Thread th2 = new Thread(new ThreadStart(stu2.DoHomework));
            ////Thread th3 = new Thread(new ThreadStart(stu3.DoHomework));
            ////th1.Start();
            ////th2.Start();
            ////th3.Start();
            ////6.3 Task方式多线程调用
            //Task task1 = new Task(new Action(stu1.DoHomework));
            //Task task2 = new Task(new Action(stu2.DoHomework));
            //Task task3 = new Task(new Action(stu3.DoHomework));
            //task1.Start();
            //task2.Start();
            //task3.Start();  

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Cyan;
            //    Console.WriteLine("Main is doing homework {0} hour(s).", i + 1);
            //    System.Threading.Thread.Sleep(500);
            //}

            //6.回调函数与高阶函数的实际应用
            //6.1 异步编程中的回调(用于异步编程和事件驱动场景)
            //Action<int, int> asyncCallback = (int x, int y) =>
            //{
            //    Console.WriteLine($"process {x} and {y}");
            //    //Thread.Sleep(20); // 模拟耗时操作
            //    Console.WriteLine($"add calculate result={x+y}");
            //};
            //asyncCallback.BeginInvoke(10, 20, result=>{ Console.WriteLine("Async oprate finished!"); },null);
            //Console.WriteLine("Main thread start async operation.");
            //6.2 高阶函数中的回调(pipline，可将多个功能模块化，进行复杂的数据处理)
            //string str = "hello world";
            //string data = ProcessData(str, str1 => str1.ToUpper(), str2 => new String(str2.Reverse().ToArray()));
            //Console.WriteLine(data);
        } 
    }
}
