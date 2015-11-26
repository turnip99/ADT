using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    class Circular_Queue
    {
        private int size;
        private int[] items;
        private int head;
        private int tail;
        private int counter;
        public Circular_Queue(int theSize)
        {
            size = theSize;
            head = 0;
            tail = 0; 
            items = new int[size];
            counter = 0;
        }
        public void push (int item)
        {
            if (head == tail && items[head] != 0)
            {
                Console.WriteLine("The queue is full.");
            }
            else
	        {
                items[tail] = item;
                counter ++;
                tail++;
                if (tail == size)
                {
                    tail = 0;
                }
	        }
        }
        public int pop()
        {
            if (counter == 0)
            {
                Console.WriteLine("The queue is empty.");
                return -1;
            }
            else
            {
                int temp = items[head];
                items[head] = 0;
                head++;
                counter--;
                if (head == size)
                {
                    head = 0;
                }
                return temp;
            }
        }
        public override string ToString()
        {
            StringBuilder details = new StringBuilder();
            details.AppendLine("Queue contains");
            foreach(int item in items)
            {
                details.AppendLine(item.ToString());
            }
            return details.ToString();
        }
    }
}
