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
            char type = 'n';
            Stack ObjStack = new Stack(8);
            Circular_Queue ObjQueue = new Circular_Queue(8);
            while (true)
            {
                Console.Clear(); 
                Console.Write("1. Initialise Stack \n2. Initialise Queue \n3. Add \n4. Remove \n5. Display All!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! \nSelection:");
                switch (Console.ReadLine())
                {
                    case "1": InitStack(ref ObjQueue, ref type); break;
                    case "2": InitQueue(ref ObjStack,ref type); break;
                    case "3": Add(ref ObjStack, ref ObjQueue, ref type); break;
                    case "4": Remove(ref ObjStack, ref ObjQueue, ref type); break;
                    case "5": Display(ref ObjStack, ref ObjQueue, ref type); break;
                    default: break;
                }
            }        
        }
        static void InitStack(ref Circular_Queue ObjQueue, ref char type)
        {
            type = 's';
            Console.WriteLine("Stack will now be used.");
            Console.ReadLine();
        }
        static void InitQueue(ref Stack ObjStack, ref char type)
        {
            type = 'q';
            Console.WriteLine("Queue will now be used.");
            Console.ReadLine();
        }
        static void Add(ref Stack ObjStack, ref Circular_Queue ObjQueue, ref char type)
        {
            Console.WriteLine("What does thou want to enter to the stack/queue (number please)?");
            int numInput;
            string input;
            bool valid = false;
            do
            {
                input = Console.ReadLine();
                if (Int32.TryParse(input, out numInput))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please actually enter a number.");
                }
            } while (valid == false);
            if (type == 's')
            {
                ObjStack.push(numInput);
                Console.WriteLine("Value added to stack.");
            }
            else if (type == 'q')
            {
                ObjQueue.push(numInput);
                Console.WriteLine("Value added to queue.");
            }
            else
            {
                Console.WriteLine("No stack or queue initialised...");
            }
            Console.ReadLine();
        }
        static void Remove(ref Stack ObjStack, ref Circular_Queue ObjQueue, ref char type)
        {
            if (type == 's')
            {
                Console.WriteLine(ObjStack.pop());
                Console.WriteLine("Value popped from stack.");
            }
            else if (type == 'q')
            {
                Console.WriteLine(ObjQueue.pop());
                Console.WriteLine("Value popped from queue.");
            }
            else
            {
                Console.WriteLine("No stack or queue initialised...");
            }
            Console.ReadLine();
        }
        static void Display(ref Stack ObjStack, ref Circular_Queue ObjQueue, ref char type)
        {
            if (type == 's')
            {
                Console.WriteLine(ObjStack);
            }
            else if (type == 'q')
            {
                Console.WriteLine(ObjQueue);
            }
            else
            {
                Console.WriteLine("No stack or queue initialised...");
            }
            Console.ReadLine();
        }
    }
}
