using System.Collections;
using System.Collections.Generic;

namespace LinkedListDemo
{
    public class Program
    {
        public static void Main(String[] args)
        {

            LinkedList linked = new LinkedList();
            linked.Add(56); // add a elemt at last postion Append is nothinf act as Add () method
            linked.Add(30);
            linked.Add(70);
            linked.Display();
            int a = linked.Search(30);
            Console.WriteLine("index position of element is :" + a);
        }
    }
}