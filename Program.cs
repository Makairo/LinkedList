using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            myList.AddSorted(9);
            myList.AddSorted(7);
            myList.AddSorted(5);
            myList.AddSorted(3);
            myList.AddSorted(11);


            myList.Print();

            myList.DeleteIndex(3);

            myList.Print();

            myList.DeleteIndex(0);

            myList.Print();

        }
    }
}
