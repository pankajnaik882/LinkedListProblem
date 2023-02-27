using System.Collections;
using System.Collections.Generic;

namespace LinkedListDemo
{
    public class Program
    {
        public static void Main(String[] args)
        {

            LinkedList linked = new LinkedList();
            linked.Append(56); // add a elemt at last postion Append is nothinf act as Add () method
            linked.Append(30);
            linked.Append(70);
            linked.display();
        }
    }
}