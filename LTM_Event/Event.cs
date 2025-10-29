using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace LTM_Event
{

    //事件模型的5个组成部分
    //1、事件的拥有者（事件源，是一个对象）
    //2、事件成员（event,是一个成员）
    //3、事件的响应者（订阅者，是一个对象）
    //4、事件处理器（event handler,是一个方法成员）--本质是一个回调方法
    //5、事件订阅--把事件处理器handler与事件event关联起来--本质是一种以委托类型为基础的“约定”
    //注意
    //1、事件处理器是方法成员
    //2、事件可以同步调用也可以异步调用
    //3、事件处理器对事件的订阅不是随意的,匹配与否与声明事件时所使用的委托类型有关

    internal class Event
    {
    }

    //1、事件响应者（事件处理器）+=（订阅） 事件拥有者（事件成员）
    public class Star1
    {
        public void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Star1 Action!");
        }
    }

    //2.star2:事件的拥有者（也是 事件的响应者）[事件+=事件处理器]
    public class MyForm1 : Form
    {
        internal void myForm1_Click(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }

    //3_1、star3 事件响应者[（事件处理器）+=（事件拥有者（事件））]
    public class Control : Form
    {
        private Form form_;
        public Control(Form form)
        {
            if(form!=null)
            {
                this.form_ = form;
                this.form_.Click += Form_Click;
            }
        }

        private void Form_Click(object sender, EventArgs e)
        {
            this.form_.Text = "Clicked! "+DateTime.Now.ToString();
        }
    }
    //3_2、star3 
    public class MyForm2:Form { 
        private TextBox textBox_;
        private Button button_;
        public MyForm2()
        {
            this.textBox_ = new TextBox();
            this.button_ = new Button();
            this.Controls.Add(this.textBox_);
            this.Controls.Add(this.button_);
            this.button_.Click += Button__Click;
            this.button_.Top = 30;
            this.button_.Text = "Click Me";
        }

        private void Button__Click(object sender, EventArgs e)
        {
           this.textBox_.Text =  DateTime.Now.ToString()+ "Button Clicked! " ;   
        }
    }

    //事件的（完整）声明-自定义委托类型

    public class OrderEventArgs : EventArgs
    {
        public string Dish { get; set; }
        public string Size { get; set; }
    }
    //public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);
    public class  Customer
    {
        //private OrderEventHandler orderEvent;
        //public event OrderEventHandler Order
        //{
        //    add
        //    {
        //        orderEvent += value;
        //    }
        //    remove
        //    {
        //        orderEvent -= value;
        //    }
        //}
        //简化事件写法
        //public event OrderEventHandler Order;
        //使用系统预定义的委托类型EventHandler
        public event EventHandler Order;
        public double Bill { get; set; }

        public void PayTheBill()
        {
           Console.WriteLine("pay the bill:$"+Bill);
        }

        public void WakeIn()
        {
            Console.WriteLine("wake in restaurant and sit down.");
        }
        //public void Think()
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.WriteLine("think...");
        //        System.Threading.Thread.Sleep(1000);
        //    }
        //    if (orderEvent != null)
        //    {
        //        OrderEventArgs e = new OrderEventArgs()
        //        {
        //            Dish = "Kung Pao Chicken",
        //            Size = "large"
        //        };
        //        orderEvent(this,e);
        //    }
        //}

        //简化写法与OnEvent模式触发
        public void Think()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Think...");
                Thread.Sleep(1000);
            }
            OnOrder("Kung Pao Chicken", "large");
        }
        public void OnOrder(string dishname, string size)
        {
            if (Order != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.Dish = dishname;
                e.Size = size;
                this.Order(this, e);
            }
        }

        public void CustomAction()
        {
            WakeIn();
            Think();
        }
    }

    public class Waiter
    {
        // public void MenuAction(Customer customer, OrderEventArgs e)
        //使用系统的预定义委托类型EventHandler
        public void MenuAction(object sender, EventArgs e)
        {
            Customer customer = sender as Customer;
            OrderEventArgs  arg = e as OrderEventArgs;
            Console.WriteLine("I will server you the dish - "+arg.Dish);
            double price = 20;
            switch (arg.Size)
            {
                case "small":
                    price *= 0.5;
                    break;
                case "large":
                    price *= 1.5;
                    break;
                default:
                    break;
            }
            customer.Bill += price;
            Console.WriteLine("you wil pay for - "+customer.Bill);
        }
    }

}
