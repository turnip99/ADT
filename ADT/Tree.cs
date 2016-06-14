using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    class Tree
    {
        private int[] node;
        private int[] left;
        private int[] right;
        private int pointer = 0;

        public Tree(int size)
        {
            node = new int[size];
            left = new int[size];
            right = new int[size];
        }

        public void addNode(int newNode)
        {
            if (pointer < node.Length)
            {
                int position;
                for (position = 0; position < node.Length; position++)
                {
                    if (node[position] == 0)
                    {
                        node[position] = newNode;
                        pointer++;
                        break;
                    }
                }
                if (position != 0)
                {
                    int rowIAmLookingAt = 0;
                    bool done = false;
                    while(done != true)
                    {
                        if (newNode < node[rowIAmLookingAt])
                        {
                            if (left[rowIAmLookingAt] == 0)
                            {
                                left[rowIAmLookingAt] = position;
                                done = true;
                            }
                            else
                            {
                                rowIAmLookingAt = left[rowIAmLookingAt];
                            }
                        }
                        else
                        {
                            if (right[rowIAmLookingAt] == 0)
                            {
                                right[rowIAmLookingAt] = position;
                                done = true;
                            }
                            else
                            {
                                rowIAmLookingAt = right[rowIAmLookingAt];
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Tree is full");
            }
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < pointer; i++)
			{
                if (left[i] != 0)
                {
                    builder.Append("Row " + i + ": " + left[i] + "(" + node[left[i]] + ")");
                }
                else
                {
                    builder.Append("Row " + i + ": " + "N/A()");
                }
                builder.Append(" <--- " + node[i].ToString() + " ---> ");
                if (right[i] != 0)
                {
                    builder.Append(right[i] + "(" + node[right[i]] + ")\n");
                }
                else
                {
                    builder.Append("N/A()\n");
                }
			}
            return builder.ToString();
        }
    }
}
