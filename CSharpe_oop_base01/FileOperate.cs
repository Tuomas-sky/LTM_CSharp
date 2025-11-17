using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpe_oop_base01
{
    public class FileOperate
    {
        public void FileStreamOP()
        {
            //方法1
            ////建立文件流
            //FileStream fs = new FileStream("a.txt", FileMode.Create);
            ////读写流
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("使用StreamWriter 写入流");
            //sw.WriteLine("写入成功");
            ////关闭流
            //sw.Close();
            //fs.Close();

            //方法2-实现IDisposable可以不用close(),出作用域会自己close
            //using(FileStream fs =new FileStream("b.txt", FileMode.Create))
            //{
            //    using (StreamWriter sw = new StreamWriter(fs))
            //    {
            //        sw.WriteLine("第二种方式写入流");
            //        sw.WriteLine("写入成功");
            //    }
            //}

            //File.WriteAllText("c.txt", "WriteAllText()函数写入文件");
            ////读取文件
            //Console.WriteLine(File.ReadAllText("c.txt"));
            //File.WriteAllText("c.txt", "WriteAllText()函数写入文件，第二次写入");//会覆盖原来的文本内容
            //Console.WriteLine(File.ReadAllText("c.txt"));
            ////追加操作
            //var append = File.AppendText("c.txt");
            //append.Write("|后是使用AppendText()追加的");
            //append.Close();//写完必须关闭close()
            //Console.WriteLine(File.ReadAllText("c.txt"));
            ////判断是否存在
            //if (File.Exists("a.txt"))
            //{
            //    var txt = File.AppendText("a.txt");
            //    txt.Write("\n文件存在进行追加");
            //    txt.Close();
            //    Console.WriteLine(File.ReadAllText("a.txt"));
            //    Console.WriteLine("追加了");
            //}
            //else
            //{
            //    File.WriteAllText("a.txt", "创建了该文件");
            //    Console.WriteLine("创建了");
            //}
            ////文件拷贝Copy
            //File.Copy("a.txt", "../a_copy.txt");
            ////文件移动
            //File.Move("b.txt", "./b_move.txt");//同路径下是重命名
            ////文件删除
            ////File.Delete()
            ////文件创建时间
            ////File.SetCreationTime("a.txt", DateTime.Now);

            ////FileInfo
            //FileInfo fi = new FileInfo("a.txt");
            //Console.WriteLine(fi.Name);
            //Console.WriteLine(fi.FullName);
            //Console.WriteLine(fi.Length);//Byte
            //Console.WriteLine(fi.CreationTime);
            //Console.WriteLine(fi.Extension);

            ////Directory
            //if (!Directory.Exists(@"System/Code"))
            //{
            //    Directory.CreateDirectory(@"System/Code");
            //    Console.WriteLine("创建了文件夹");
            //}
            //else
            //{
            //    Console.WriteLine("文件夹存在");
            //}

            ////得到指定文件夹下的文件
            //var files = Directory.GetFiles("./");
            //foreach (var file in files)
            //{
            //    FileInfo fileInfo = new FileInfo(file);
            //    Console.WriteLine(fileInfo.FullName);
            //    //Console.WriteLine(file);
            //}
            //Console.WriteLine("========================");
            //var dir = Directory.GetDirectories("./");
            //foreach (var item in dir)
            //{
            //    DirectoryInfo di = new DirectoryInfo(item);
            //    Console.WriteLine(di.FullName);
            //}

            Directory.CreateDirectory(@"System/Code2");
            try
            {
                Directory.Delete(@"System/Code");
            }
            catch (Exception)
            {
                Console.WriteLine("是否真的删除");
                if (Console.ReadLine().Trim() == "y")
                {
                    Directory.Delete(@"System/Code", true);
                }
                Console.WriteLine("删除操作已被记录");
            }

        }
    }
}
