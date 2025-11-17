using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpe_oop_base01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1、interface
            //OOP_Base oop_base = new OOP_Base();
            //oop_base.OOP_Value_Ref();
            //IPerson boy = new Boy();//只能看到接口里面提供的成员，实现类里新增的成员看不到
            //boy.Name = "Tom";
            //boy.SayHi("lisi");
            //Boy boy1=boy as Boy;
            //boy1.Study();

            ////2、file stream operate
            //FileOperate fileOperate = new FileOperate();
            //fileOperate.FileStreamOP();

            ////3、Serialize序列化与反序列化DeSerialize
            //Serialize serialize = new Serialize();
            //serialize.Serializalbe();

            //4、reflect
            Reflect reflect = new Reflect();
            reflect.ReflectOP();




        }
    }
}
