using System;

namespace ProgrammingPractice.Ex01
{
    public class Node
    {
        public int Data;
        public Node? Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class MyLinkedList
    {
        public Node? Head;

        public MyLinkedList()
        {
            Head = null;
        }

        public void InsertNode(int data)
        {
            Node newNode = new Node(data);
            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node? current = Head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

        }
        
        public void PrintList()
        {
            Node? current = Head;
            while(current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public void execute()
        {
            int listCount = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < listCount; i++)
            {
                int listItem = Convert.ToInt32(Console.ReadLine());
                this.InsertNode(listItem);
            }

            this.PrintList();
        }
    }
}