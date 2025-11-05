using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class LinkedList
    {
        private Node head;
        public LinkedList() { head = null; }
        public void Addfirst(int data)
        {
            Node newnode = new Node(data);
            newnode.Next = head;
            head = newnode;
            Console.WriteLine($"Đã thêm {data} vào đầu danh sách mới");
        }
        public void Addlast(int data)
        {
            Node Newnode = new Node(data);
            if(head == null)
            {
                head = Newnode;
                Console.WriteLine($"Đã thêm {data} vào danh sách rỗng");
                return;
            }    
            Node current = head;
            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Next = Newnode;
            Console.WriteLine($"Đã thêm {data} vào cuối danh sách");
        }
        public void Display()
        {
            if (head == null)
                Console.WriteLine("Danh sách rỗng");
            Node current = head;
            while(current!=null)
            {
                Console.Write(current);
                current = current.Next;
                Console.WriteLine();
            }
            Console.WriteLine("null");
        }
        public int count()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

    }
}
