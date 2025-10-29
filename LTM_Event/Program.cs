using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace LTM_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1、事件响应者（事件处理器）+=（订阅） 事件拥有者（事件成员）
            //System.Timers.Timer timer = new System.Timers.Timer(); 
            //timer.Interval = 1000; //设置时间间隔为1秒
            //Star1 star1 = new Star1();
            //timer.Elapsed += star1.Action; //订阅事件 
            //timer.Start(); //启动定时器
            //Console.ReadLine();

            ////2.star2:事件的拥有者（也是 事件的响应者）[事件+=事件处理器]
            //MyForm1 myForm1 = new MyForm1();
            //myForm1.Click+=myForm1.myForm1_Click;
            //myForm1.ShowDialog();

            ////3_1、star3 事件响应者[（事件处理器）+=（事件拥有者（事件））]
            //Form form = new Form();
            //Control control = new Control(form);
            //form.ShowDialog();
            //3_2、
            //MyForm2 myForm2 = new MyForm2();
            //myForm2.ShowDialog();

            //4.
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.MenuAction;
            customer.CustomAction();
            customer.PayTheBill();
        }

        
    }
}
