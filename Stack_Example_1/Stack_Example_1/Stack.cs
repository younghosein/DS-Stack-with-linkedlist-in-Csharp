using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Example_1
{
    class Stack
    {
        public Node top;
        public Stack()
        {
            top = null;
        }
        public void print()
        {
            if (top == null)
            {
                Console.Write("\nStack Is Full !");
                return;
            }
            else
            {
                Node n = top;
                while (n != null)
                {
                    Console.Write(n.data + " . ");
                    n = n.next;
                }
            }
        }
        public bool isempty()
        {
            return top == null;
        }
        public void push(int data)
        {
            Node nn = new Node(data);

            if (nn == null)
            {
                Console.Write("\nStack Is Full !");
                return;
            }

            nn.next = top;

            top = nn;
        }
        public int peek()
        {
            if (!isempty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack Is Empty !");
                return -1;
            }
        }
        public void DelCopy(Node t)
        {

            int max = int.MinValue;

            while (t != null)
            {
                if (max < t.data)
                    max = t.data;
                t = t.next;
            }
            int d = max;

            Node n = head;
            Node bn = null;

            if (n != null && n.data == d)
            {
                head = n.next;
                return;
            }

            while (n != null && n.data != d)
            {
                bn = n;
                n = n.next;
            }

            if (n == null)
                return;

            bn.next = n.next;
        }
        public void pop()
        {
            if (top == null)
            {
                Console.Write("\nStack Is Full !");
                return;
            }
            Console.WriteLine($"{top.data} Is Deleted...");
            top = top.next;
        }
        public int Avg()
        {
            int sum = 0;
            int c = 0;
            int avg;
            Node n = top;
            while (n != null)
            {
                sum += n.data;
                c++;
                n = n.next;
            }
            Console.Write($"Sum Is : {sum}");
            Console.Write($"\nCount Is : {c}\n");
            avg = sum / c;
            return avg;
        }
    }
}
