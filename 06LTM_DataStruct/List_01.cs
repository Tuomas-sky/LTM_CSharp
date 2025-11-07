using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace _06LTM_DataStruct
{
    /// <summary>
    /// List<T>一些常识：
    /// 底层实现中，以一个数组来承载数据，又称为动态数组。
    /// 它的容量是可以动态增长的，当添加元素时，如果当前容量不够，就会分配一个更大的数组，并将原有数据复制过去。
    /// 与非泛型ArrayList相对应
    /// 与C++中vector<T>等价
    /// </summary>

    public class List_01
    {
        public void Create_Delete_ListBaseOperate()
        {
            //1.List
            //初始化列表构造
            List<int> list = new List<int>() { 1, 2, 5, 7, 8 };
            Console.WriteLine(list.Count + " / " + list.Capacity);
            Console.WriteLine(String.Join(",", list));
            //传递IEnumerable<T>接口
            int[] arr = new int[] { 10, 20, 30 };
            list = new List<int>(arr);
            Console.WriteLine(list.Count + " / " + list.Capacity);
            Console.WriteLine("list1:" + String.Join(",", list));
            //添加元素
            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
                Console.WriteLine(list.Count + " / " + list.Capacity);
            }
            Console.WriteLine("list2:" + String.Join(",", list));
            //AtRange 添加一段元素
            List<int> list2 = new List<int> { 10, 20, 30 };
            List<int> list3 = new List<int>() { 1, 2, 3, 4, 5 };
            list3.AddRange(list2);
            Console.WriteLine("list3:" + String.Join(",", list3));
            //insertRange 插入一段元素
            List<int> list4 = new List<int>() { 1, 2, 3, 4, 5 };
            list4.InsertRange(1, arr);
            list4.Insert(0, 200);
            Console.WriteLine("list4: " + String.Join(",", list4));
            //clear 清空元素
            list4.Clear();
            Console.WriteLine(list4.Count+" / "+list4.Capacity);

            //RemoveAt 删除元素
            List<int> list5 = new List<int>() { 1, 2, 3, 4, 5,6,7,8,9};
            list5.Remove(6);
            list5.RemoveAt(0);
            list5.RemoveRange(0, 2);
            Console.WriteLine("list5: " + String.Join(",", list5));
            list5.RemoveAll(x => x % 2 == 0);
            Console.WriteLine("removeAll list5: "+String.Join(",",list5));


        }

        public void Read_ListBaseOperate()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            List<Book> books = new List<Book>();
            for (int i = 1; i <= 10; i++)
            {
                books.Add(new Book() { Id = i, Name = "Book_" + i, Price = i * 10 });
            }
            Console.WriteLine("listint: "+list.Count+" / "+list.Capacity);
            Console.WriteLine("booksinit: "+books.Count+" / "+books.Capacity);
            Console.WriteLine("=================================");
            //Console.WriteLine(books[0]);
            //Console.WriteLine(books[books.Count-1]);
            //read
            list[0] = 100;
            Console.WriteLine(list[0]);
            List<int> list2 = list.GetRange(1, 3);
            foreach (var item in list2)
            {
                Console.Write(item.ToString()+"，");
            }
            int sum = 0;
            list2.ForEach(val => sum += val);
            Console.WriteLine("\nlist2 sum="+sum);
            //可迭代
            Console.WriteLine("=====可迭代=====\n");
            List<int>.Enumerator e = list2.GetEnumerator();
            Console.WriteLine(e.Current);
            while(e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }
            Console.WriteLine(e.Current);
            Console.WriteLine("=====================indexof=================");
            //indexof
            List<int> list3 = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            Console.WriteLine(list3.IndexOf(2));
            Console.WriteLine(list3.IndexOf(2,3));
            Console.WriteLine(list3.IndexOf(2,3,7));
            Console.WriteLine(list3.IndexOf(2,3,2));


        }

        public void Find_ListBaseOperate()
        {
            List<int> list = new List<int>() { 80, 70, 60, 50, 40, 30, 20, 10 };
            Book book1 = new Book() { Id = 1, Name = "Book-1", Price = 10 };
            Book book2 = new Book() { Id = 2, Name = "Book-2", Price = 20 };
            Book book3 = new Book() { Id = 3, Name = "Book-3", Price = 30 };
            Book book4 = new Book() { Id = 4, Name = "Book-4", Price = 40 };
            Book book5 = new Book() { Id = 1, Name = "Book-1", Price = 10 };
            Book book6 = book1;
            List<Book> books = new List<Book>() { book1, book2, book3, book4 };

            var res = list.Find(e => e % 3 == 0);
            Console.WriteLine(res);
            Console.WriteLine(books.Find(e=>e.Price%3==0));
            Console.WriteLine(String.Join(",",list.FindAll(e=>e%3==0)));
            Console.WriteLine(list.FindIndex(e=>e%3==0));
            Console.WriteLine(list.FindIndex(3,e=>e%3==0));
            Console.WriteLine(list.FindIndex(3,4,e=>e%3==0));
            Console.WriteLine(list.FindIndex(3,2,e=>e%3==0));

            //Sort
            Console.WriteLine("=======Sort======");
            list.Sort();
            Console.WriteLine(String.Join(",",list));
            var it = list.BinarySearch(20);//返回索引位置
            Console.WriteLine(it);
            books.Sort();
            Console.WriteLine(String.Join("\n",books) );
            var it2 = books.BinarySearch(book1);//返回索引位置
            Console.WriteLine(it2);
            var it3 = books.BinarySearch(book5);//返回索引位置
            Console.WriteLine(it3);

        }
       


    }

    public class Book:IComparable<Book>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
           // return $"Id:{Id}, Name:{Name}, Price:{Price}";
           return JsonSerializer.Serialize(this);
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is Book b)
            {
                return this.Id == b.Id && this.Name == b.Name && this.Price == b.Price;
            }
            return false;
        }

        public int CompareTo(Book other)//当前>other 返回1，当前<other返回-1，相等返回0
        {
            if (other == null) return 1;
            return this.Id-other.Id;
        }
    }

    

}
