using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    class Stack
    {
        private int size;
        private int[] items;
        private int pointer;
        public Stack(int theSize)
        {
            size = theSize;
            pointer = 0; 
            items = new int[size];
        }
        public void push(int newValue)
        {
            if (pointer != size)
            {
                items[pointer] = newValue;
                pointer++;
            }
            else
            {
                Console.WriteLine("Stack is full!");
            }
        }
        public int pop() 
        {
            if (pointer > 0)
            {
                int temp = items[pointer-1];
                items[pointer-1] = 0;
                pointer--;
                return temp;
	        }
            else
            {
                Console.WriteLine("Stack is empty...");
                return -1;
            }
        }
        public override string ToString()
        {
            StringBuilder details = new StringBuilder();
            details.AppendLine("Stack contains");
            foreach(int item in items)
            {
                details.AppendLine(item.ToString());
            }
            return details.ToString();
        }
    }
}
