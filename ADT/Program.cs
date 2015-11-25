using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(8);
            stack.push(3);
            Console.WriteLine(stack);
            Console.ReadLine();
            stack.push(9);
            Console.WriteLine(stack);
            Console.ReadLine();
            stack.push(31);
            Console.WriteLine(stack);
            Console.ReadLine();
            stack.push(7);
            Console.WriteLine(stack);
            Console.ReadLine();
            stack.pop();
            Console.WriteLine(stack);
            Console.ReadLine();
            stack.pop();
            Console.WriteLine(stack);
            Console.ReadLine();
            stack.push(3);
            Console.WriteLine(stack);
            Console.ReadLine();
            stack.push(7);
            Console.WriteLine(stack);
            Console.ReadLine();
            stack.pop();
            Console.WriteLine(stack);
            Console.ReadLine();
            stack.pop();
            Console.WriteLine(stack);
            Console.ReadLine();
        }
    }
}
