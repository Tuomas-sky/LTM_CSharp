using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CSharpe_oop_base01
{
    [Serializable]
    public class Student {
        public int Age { get; set; }
        public string Name { get; set; }

    }

    public class Serialize
    {
        public void Serializalbe()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Age = 1, Name = "Tom1" },
                new Student() { Age = 2, Name = "Tom2" },
                new Student() { Age = 3, Name = "Tom3" },
                new Student() { Age = 4, Name = "Tom4" },
            };
            //序列化
            BinaryFormatter bf = new BinaryFormatter();
            using(FileStream fs =new FileStream("serialize.bin", FileMode.Create))
            {
                bf.Serialize(fs, students);
            }
            //反序列化
            BinaryFormatter debf = new BinaryFormatter();
            using(FileStream fs = new FileStream("serialize.bin",FileMode.Open))
            {
                var data = debf.Deserialize(fs) as List<Student>;
                foreach (var item in data)
                {
                    Console.WriteLine($"Age:{item.Age},Name:{item.Name}");
                }

            }



        }
    }
}
