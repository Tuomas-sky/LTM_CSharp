using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    //事件的五个部分：
    //1、事件的拥有者（事件源，对象）
    //2、事件成员（event，成员）
    //3、事件的响应者（event subscriber订阅者，对象）
    //4、事件处理器（event Handler，成员）--本质是一个回调方法
    //5、事件订阅： 把事件处理器与事件成员关联起来（+=），本质是一种以委托类型为基础的约定
    //注意：
    //1、事件处理器是方法成员


    internal class Event
    {
    }
}
