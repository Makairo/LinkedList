using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            myList.Append(9);
            myList.Append(7);
            myList.Append(5);
            myList.Append(3);
            myList.Append(11);


            myList.Print();

            myList.Sort();


            myList.Print();

        }
    }
}
