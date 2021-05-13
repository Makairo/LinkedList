using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node
    {
        public int data
        {
            get; private set;
        }

        public Node next;
        private static int count = 0;

        public Node()
        {
            data = 0;
            next = null;
        }
        public Node(int input)
        {
            data = input;
            next = null;
        }

        public void Append(int input)
        {
            if(next == null)
            {
                next = new Node(input);
            }
            else
            {
                next.Append(input);
            }
        }
        
        public void DeleteWithValue(int input)
        {
            if (next != null)
            {
                if(next.data == input)
                {
                    next = next.next;
                    this.DeleteWithValue(input);
                }
                else
                {
                    next.DeleteWithValue(input);
                }
                
            }
        }

        public void DeleteIndex(int index)
        {
            count++;
            if (count == index)
            {
                this.next = next.next;
            }
            if (next == null)
            {
                return;
            }
            else
            {
                
                next.DeleteIndex(index);
            }
            count = 0;
        }

        public void Insert(int index, int input)
        {
            count++;

            if (count == index)
            {
                this.data = input;
            }
            if (next == null)
            {
                return;
            }
            else
            {
                next.Insert(index, input);
            }
            count = 0;
        }

        public int Count()
        {
            count++;
            if(next != null)
            {
                return next.Count();
            }
            else
            {
                int temp = 0;
                if (count > 0) temp = count;
                
                count = 0;
                return temp;
            }
        }

        public void Print()
        {
            
            if(next != null)
            {
                Console.Write(" | " + data + " | " + "->");
                next.Print();
            }
            else
            {
                Console.WriteLine(" | " + data + " | ");
            }
        }

        public void AddSorted(int input)
        {
            if (next == null)
            {
                next = new Node(input);
            }
            else if (input < next.data)
            {
                Node temp = new Node(input);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(input);
            }
        }

        public void Sort()
        {
            if (next == null)
            {
                return;
            }
            if(next.next == null)
            {
                while (this.data > next.data)
                {
                    int temp = this.data;
                    this.data = next.data;
                    next.data = temp;
                    next.Sort();
                }
            }
            else
            {
                while (next.data > next.next.data)
                {
                    int temp = next.data;
                    next.data = next.next.data;
                    next.next.data = temp;
                    next.Sort();
                }
                while (this.data > next.data)
                {
                    int temp = this.data;
                    this.data = next.data;
                    next.data = temp;
                    next.Sort();
                }
            }
            
            next.Sort();


        }


    }




    public class LinkedList
    {
        Node HeadNode;

        public LinkedList()
        {
            HeadNode = null;
        }

        public LinkedList(int input)
        {
            HeadNode = new Node(input);
        }

        public void Append(int input)
        {
            if(HeadNode == null)
            {
                HeadNode = new Node(input);
            }
            else
            {
                HeadNode.Append(input);
            }
        }

        public void AddSorted(int input)
        {
            if(HeadNode == null)
            {
                HeadNode = new Node(input);
            }
            else if (input < HeadNode.data)
            {
                Prepend(input);
            }
            else
            {
                HeadNode.AddSorted(input);
            }
        }

        public void Sort()
        {
            if(HeadNode == null)
            {
                return;
            }
            HeadNode.Sort();
        }

        public void Prepend(int input)
        {
            if (HeadNode == null)
            {
                HeadNode = new Node(input);
            }
            else
            {
                Node temp = new Node(input);
                temp.next = HeadNode;
                HeadNode = temp;
            }
        }

        public void Print()
        {
            if(HeadNode == null)
            {
                return;
            }
            HeadNode.Print();
        }

        public void DeleteWithValue(int input)
        {
            if (HeadNode == null)
            {
                return;
            }
            if (input == HeadNode.data)
            {
                HeadNode = HeadNode.next;
            }else
            {
                HeadNode.DeleteWithValue(input);
            }
        }

        public void DeleteIndex(int index)
        {
            if (HeadNode == null)
            {
                return;
            }
            if (index == 0)
            {
                HeadNode = HeadNode.next;
            }
            else
            {
                HeadNode.DeleteIndex(index);
            }
        }

        public int Count()
        {
            if(HeadNode == null)
            {
                return 0;
            }
            else
            {
                return HeadNode.Count();
            }
        }

        public void Insert(int index, int input)
        {
            if (HeadNode == null)
            {
                Prepend(input);
            }
            else
            {
                HeadNode.Insert(index, input);
            }
        }

    }
}
