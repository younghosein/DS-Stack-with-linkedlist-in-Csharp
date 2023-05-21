using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();

            s.push(34);
            s.push(89);
            s.push(15);
            s.push(97);
            s.push(26);
            s.push(55);
            s.push(43);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Stack Is : ");
            s.print();
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            s.pop();
            s.pop();
            Console.WriteLine("Now Stack Is : ");
            s.print();
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Top Is : ");
            int p = s.peek();
            Console.WriteLine(p);
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int a = s.Avg();
            Console.WriteLine("Average Is : ");
            Console.WriteLine(a);
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
