using System;
using System.Collections.Generic;//泛型
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLib;
//Add ref Windows.Forms 
namespace LTM_ClassAndInstance
{

    //
    internal class Program
    {
        static void Main(string[] args)
        {
#if false
            //1.实例
            //Form form = new Form();//创建一个Form类的实例,form是Form类的一个对象(form是引用变量)
            //form.Text = "My First Form";//孩子form与气球Form的关系
            //form.WindowState = FormWindowState.Normal;
            //form.ShowDialog();
            //Calculate c = new Calculate();
            //c.AddXTo1(3);

            //2.栈溢出
            //StackOverFlow s = new StackOverFlow();
            //s.BadMethord();

            //3、数组遍历
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //4.Convert数据类型转化
            //int i = -1000;
            //string str = Convert.ToString(i,2);
            //Console.WriteLine(str);

            //5.运算符重载与字典dict访问
            //double area = Calculate.GetConeV(2,3);
            //Person p1 = new Person();
            //Person p2 = new Person();
            //p1.Name = "Tom";
            //p2.Name = "Mary";
            ////List<Person> children = Person.GerMarry(p1, p2);
            //List<Person> children = p1+p2;
            //foreach (Person child in children)
            //{
            //    Console.WriteLine(child.Name);
            //}
            //Dictionary<string,Person> dict = new Dictionary<string, Person>();
            //for (int i = 1; i <= 10; i++)
            //{
            //    Person p =  new Person();
            //    p.Name = "Person_"+i.ToString();
            //    p.Score = i + 100;
            //    dict.Add(p.Name, p);
            //}
            //Console.WriteLine(dict["Person_1"].Score);

            //6.Type类型运算符
            //Type t = typeof(int);
            //Console.WriteLine(t.Namespace);
            //Console.WriteLine(t.FullName);
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.IsClass);
            //Console.WriteLine(t.IsValueType);
            //int count = t.GetMethods().Length;
            //foreach(var item in t.GetMethods())
            //{
            //    Console.WriteLine(item.Name);
            //}
            //Console.WriteLine("int的方法数："+count);


            //7.显式/隐式类型转换 explicit /implicit
            //Stone s = new Stone();
            //s.Age = 5000;
            //Monkey m = s;//隐式转换
            //Console.WriteLine(m.Age);

            //8.is & as使用
            //Person p = new Person();
            //if(p is Animal)//is 返回true or false
            //{
            //    Animal a = p as Animal;//as 返回null or 指定对象
            //    a.Eat();
            //}
            //else
            //{
            //    Console.WriteLine("p不是Animal类型");
            //}
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(arr.GetType().FullName);
            //Console.WriteLine(arr is Array);

            //9.可空运算符?
            //int? x = null;
            //if (x.HasValue)
            //{
            //    Console.WriteLine(x.Value);
            //}
            //else
            //{
            //    Console.WriteLine("x没有值，自动添加默认值");
            //    x = x ?? 1;
            //    Console.WriteLine($"x没有值，自动添加默认值{x}");
            //}

            //10.条件语句if /switch
            //switch used
            //int score = 5;
            //switch (score/10)
            //{
            //    case 10:
            //        if(score ==100)
            //            goto case 9;
            //        else
            //            goto default;
            //    case 9:
            //    case 8:
            //        Console.WriteLine("A");
            //        break;
            //    case 7:
            //    case 6:
            //        Console.WriteLine("B");
            //        break;
            //    case 5:
            //    case 4:
            //        Console.WriteLine("C");
            //        break;
            //    case 3:
            //    case 2:
            //    case 1:
            //    case 0:
            //        Console.WriteLine("D");
            //        break;
            //    default:
            //        Console.WriteLine("Input Error!");
            //        break;  
            //}

            //11.异常处理try catch finally throw
            //Calculate c = new Calculate();
            ////c.Add(null, "200");
            ////main函数中捕获异常
            //int res = 0;
            //try
            //{
            //    res = c.Add(null, "200");
            //}
            //catch (ArgumentNullException ane)
            //{
            //    Console.WriteLine("main func call process exception " + ane.Message);
            //}

            //12.静态只读字段
            //Console.WriteLine(Brush.DefaultColor.Red);
            //Console.WriteLine(Brush.DefaultColor.Green);
            //Console.WriteLine(Brush.DefaultColor.Blue);
            ////Brush.DefaultColor = new Color { Red = 255, Green = 255, Blue = 255 };//无法对静态只读字段赋值

            //13.index索引器 & 输出参数out
            //Student1 s1=new Student1();
            //s1["Math"] = 99;
            //var score = s1["Math"];
            //Console.WriteLine(score);
            //Console.WriteLine(Student1.SchoolName);
            //Student1 stu1 = null;
            //bool res = Student1Factory.Create("Tom", 20, out stu1);
            //if (res==true)
            //{
            //    Console.WriteLine("Name={0},Age={1}",stu1.Name,stu1.Age);
            //}

            //14.数组参数
            //int sum = CalculateSum.Sum(1, 2, 3, 4, 5);
            //Console.WriteLine("sum={0}",sum);
            //string str = "hello,CSharp.C++;Java;Python";
            //string[] res = str.Split(',', ';', '.');
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //15.扩展方法
            //double pi = 3.14159;
            //Console.WriteLine(DoubleExtension.Round(pi, 3));
            //double externd = pi.Round(2);
            //Console.WriteLine(externd);
            //List<int> list = new List<int>() { 11,12,13,14};
            //Console.WriteLine(list.GreateThanTen());
            ////LINQ
            //Console.WriteLine(list.All(var=>var>10));
            //bool gt10 = list.All(var => var > 10);
            //Console.WriteLine(gt10);
            //bool any_gt13 = list.Any(var => var > 13);
            //Console.WriteLine(any_gt13);

            //16. delegate & event
            //EventHandlerTemperature t = new EventHandlerTemperature();
            //t.TempratureChanged += newTemperature => { Console.WriteLine("Temperature=" + newTemperature); };
            //t.Temperature = 37.5;
            //Subject subject = new Subject();
            //Observer observer = new Observer(subject);
            //subject.State = 1;
#endif

            //MyClassLib 引用，OOP，interface
#if false
            ////17.引用MyClassLib
            //MyClassLib.MyNamespace.Calculator calc = new MyClassLib.MyNamespace.Calculator();
            //Console.WriteLine(calc.Add(1, 2));

            ////18.OOP---可见的签名一致的函数成员
            //Type t = typeof(Car);
            //Console.WriteLine(t.BaseType.FullName);
            //Console.WriteLine(t.BaseType.BaseType.FullName);
            //Car car = new Car();
            //Console.WriteLine(car is Vehical);
            ////car.ShowOwner();
            //car.Refuel(100);
            //car.Acculerate();
            //Console.WriteLine(car.Speed);
            //car.TurboAcc();
            //Console.WriteLine(car.Speed);
            //Vehical v = new Car();//多态（子类只有一个版本），与引用的实例类型有关；
            //                      //如果不是多态（子类有两个版本），则调用父类的方法（子类中同时用于子类和父类的Run()方法）
            //v.Run();//调用子类重写的方法
            //Console.WriteLine(v.PolySpeed);
            //Vehical v2 = new Vehical();
            //v2.Run();
            //Console.WriteLine(v2.PolySpeed);

            //RaceCar raceCar = new RaceCar();
            //raceCar.GetType();

            //引出接口
            //Vehical v1 = new Car();
            //v1.Run();
#endif
            //19.引用MyClassLib 泛型--泛型类
            Apple apple = new Apple() { Color = "Red" };
            Book book = new Book() { Name = "C# Programming" };
            Box<Apple> appleBox = new Box<Apple>() { Cargo = apple };
            Box<Book> bookBox = new Box<Book>() { Cargo = book };
            Console.WriteLine(appleBox.Cargo.Color);
            Console.WriteLine(bookBox.Cargo.Name);

            //20.引用MyClassLib 泛型--泛型接口
            Student1<int> stu1 = new Student1<int>() { Id = 1001, Name = "Tom" };
            Console.WriteLine("stu1.Id={0},stu2.Name={1}", stu1.Id, stu1.Name);
            Student2 stu2 = new Student2() { Id = 2001, Name = "Mary" };
            Console.WriteLine("stu2.Id={0},stu2.Name={1}", stu2.Id, stu2.Name);

            //21. .Net 内置泛型集合，泛型--数据结构
            IList<int> list = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                list.Add(i);    
            }
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            IDictionary<int,string> dict =new Dictionary<int,string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            Console.WriteLine("# 1 is {0}",dict[1]);
            Console.WriteLine("# 2 is {0}", dict[1]);

            //22.泛型--算法
            int[] arr1 = new int[] { 1, 3, 5, 7, 9 };
            int[] arr2 = new int[] { 2, 4, 6, 8, 10 };
            int[] zip = Zipped(arr1, arr2);
            Console.WriteLine("Zipped Array:");
            foreach (var item in zip)
            {
                Console.Write(item + " ");
            }
            double[] d1 = new double[] { 1.1, 3.3, 5.5 };
            double[] d2 = new double[] { 2.2, 4.4, 6.6, 8.8 };
            double[] zipd = Zipped(d1, d2);
            Console.WriteLine("\nZipped Double Array:");
            foreach (var item in zipd)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //23.泛型--泛型委托 Action & Func
            GenericMethod gm = new GenericMethod();
            Action<string> str = gm.ShowMsg;
            Func<int,int,int> multiply = gm.Multiply;
            str("Program");
            Func<double, double, double> add = (x, y) => x + y;
            Console.WriteLine(multiply(10,20));
            Console.WriteLine(add(100,200));




        }
        //泛型方法
        static T[] Zipped<T>(T[] a, T[] b)
        {
            T[] zip = new T[a.Length+b.Length];
            int z = 0, x = 0, y = 0;
            do
            {
                if (x < a.Length)
                {
                    zip[z++] = a[x++];
                }
                if (y < b.Length)
                {
                    zip[z++] = b[y++];
                }
            } while (x < a.Length || y < b.Length);
            return zip;
        }
    }

    //扩展方法
    public static class DoubleExtension 
    {
        public static double Round(this double d ,int digits)
        {
            return Math.Round(d, digits);
        }

        public static bool GreateThanTen(this List<int> initList)
        {
            foreach(var item in initList)
            {
                if (item <= 10)
                {
                    return false;
                }
            }
            return true;
        }
    }

    //数组参数
    public class CalculateSum { 
        public static int Sum(params int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }
    }


    public class Student1
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public const string SchoolName = "LTM School";//const修饰的字段是静态的.类名＋访问

        private Dictionary<string, int> scores = new Dictionary<string, int>();

        public int? this[string subject]
        {
            get {
                if (scores.ContainsKey(subject))
                {
                    return scores[subject];
                }
                else
                {
                    return null;
                }
            }
            set {
                if (value.HasValue == false)
                {
                    throw new Exception("Score must have a value");
                }
                if (scores.ContainsKey(subject))
                {
                    scores[subject] = value.Value;
                }
                else
                {
                    scores.Add(subject, value.Value);
                }
            }
        }

    }

    public class Student1Factory
    {
        public static bool Create(string name,int age,out Student1 stu)
        {
            stu = null;
            if (string.IsNullOrEmpty(name) && age<18 && age>80)
            {
                return false;
            }
            stu = new Student1() { Name=name,Age=age};
            return true;
        }
    }
    public struct Color {
      public int Red;
      public int Green;
      public int Blue;
    }
    public class Brush
    {
        public static readonly Color DefaultColor;
        static Brush()
        {
            Brush.DefaultColor = new Color { Red = 0, Green = 0, Blue = 0  };
        }
    }

    public class Calculate
    {

        public static double GetCircleArea(double r)
        {
            return 3.14 * r * r;
        }

        public static double CylinderV(double r, double h)
        {
            return GetCircleArea(r) * h;
        }

        public static double GetConeV(double r, double h)
        {
            return CylinderV(r, h) / 3;
        }

        public int AddXTo1(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                int result = x + AddXTo1(x - 1);
                return result;
            }
        }

        public int Add(string s1,string s2)
        {
            int x = 0;
            int y=0;
            try
            {
                x=int.Parse(s1);
                y=int.Parse(s2);
            }
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Your argument(s) input error!");
            //}
            catch (OverflowException ex)
            {
                Console.WriteLine("Out of Range! "+ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Format Error! " + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                // Console.WriteLine("ArgumentNullException! " + ex.Message);
                throw ex;//异常继续抛出
            }
            finally
            {
                Console.WriteLine("finally 一般用于回收资源。");
            }

            int res = x + y;
            return res;
        }


    }

    //convert
    class Stone
    {
        public int Age;

        //public static explicit operator Monkey(Stone s)//显示
        public static implicit operator Monkey(Stone s)//隐式
        {
            Monkey m = new Monkey();
            m.Age = s.Age / 500;
            return m;
        }
    }
    class Monkey
    {
        public int Age;
    }


    //operator
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Person : Animal
    {
        public string Name;
        public int Score;
        //public static List<Person> GerMarry(Person p1, Person p2)
        public static List<Person> operator +(Person p1, Person p2)
        {
            List<Person> children = new List<Person>();
            for (int i = 0; i < 3; i++)
            {
                Person child = new Person();
                child.Name = p1.Name + " & " + p2.Name + " 's Child";
                children.Add(child);
            }
            return children;
        }

        public void Teach()
        {
            Console.WriteLine("Hello, I'm Teaching.");
        }
    }


   

    class StackOverFlow
    {
        public void BadMethord()
        {
            int x = 100;
            this.BadMethord();
        }

    }

    class EventHandlerTemperature
    {
        public delegate void TempratureChangedHandler(double newTemperature);
        public event TempratureChangedHandler TempratureChanged;
        private double _temperature;
        public double Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    OnTempratureChanged(value);
                }
            }
        }
        public virtual void OnTempratureChanged(double newTemperature)
        {
            TempratureChanged?.Invoke(newTemperature);
        }
    }

    //观察者模式
    class Subject
    {
        public event EventHandler StateChanged;
        private int _state;
        public int State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    OnStateChanged(EventArgs.Empty);
                }
            }
        }
        protected virtual void OnStateChanged(EventArgs e)
        {
            StateChanged?.Invoke(this, e);
        }
    }
    class Observer
    {
        public Observer(Subject subject)
        {
            subject.StateChanged += Subject_StateChanged;
        }

        private void Subject_StateChanged(object sender, EventArgs e)
        {
            Console.WriteLine("State changed : " + ((Subject)sender).State);
        }
    }

}