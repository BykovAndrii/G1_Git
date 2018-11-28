using System;
using System.Collections.Generic;

namespace TestingGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!!");

            //List<string> list = new List<string> { "1", "2", "3", };

            //Console.WriteLine(list.Count);

            //for (int i = 0; i <= list.Count; i++)
            //{
            //    list.Remove(list[i]);
            //}

            //Console.WriteLine(list.Count);

            //foreach (var str in list)
            //{
            //    Console.WriteLine(str);
            //}

            //Test testClass = new Test();
            //testClass.listInClass = list;

            //testClass.listInClass.Add("test");

            //foreach (var item in testClass.listInClass)
            //{
            //    Console.WriteLine(item);
            //}

            DbConnect dbConnect = new DbConnect();

            dbConnect.SelectList();
            //dbConnect.Count();

            Console.ReadKey();
        }
    }
}
