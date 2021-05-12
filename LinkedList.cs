using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node
    {
        public int data;
        public Node next;
        static int count = 0;

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
            else
            {
                
                next.DeleteIndex(index);
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
            HeadNode.Print();
        }

        public void DeleteWithValue(int input)
        {
            HeadNode.DeleteWithValue(input);
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
            return HeadNode.Count();
        }

    }
}
