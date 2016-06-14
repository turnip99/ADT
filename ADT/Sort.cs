using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    class Sort
    {
        public int[] BubbleSort(int[] data)
        {
            bool actuallySwappedSomething = true;
            int temp;
            while (actuallySwappedSomething)
            {
                actuallySwappedSomething = false;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        actuallySwappedSomething = true;
                        temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
                    }
                }
            }
            return data;
        }

        public void SplitOld(int[] data, int left, int right)
        {
            //  for (int i = left; i <= right; i++)
            //{
            //  Console.Write(data[i]);
            //Console.Write(",");
            //}
            //Console.WriteLine();
            int mid;
            mid = (left + right) / 2;
            if (right > left)
            {
                SplitOld(data, left, mid);
                SplitOld(data, mid + 1, right);
            }
            int[] temp = new int[data.Length];
            int start1 = left;
            int end1 = mid;
            int end2 = right;
            int start2;
            if (end2 > mid)
            {
                start2 = mid + 1;
            }
            else
            {
                start2 = mid;
            }
            int position = start1;
            Console.WriteLine("Start1 = {0} ", start1);
            Console.WriteLine("End1 = {0} ", end1);
            Console.WriteLine("Start2 = {0} ", start2);
            Console.WriteLine("End2 = {0} ", end2);
            Console.WriteLine("");
            while ((start1 <= end1) && (start2 <= end2))
            {
                if (data[start1] < data[start2])
                {
                    temp[position] = data[start1];
                    start1++;
                    position++;
                }
                else
                {
                    temp[position] = data[start2];
                    start2++;
                    position++;
                }
            }
            if (start1 != end1)
            {
                for (int i = start1; i < end1; i++)
                {
                    temp[position] = data[i];
                    position++;
                }
            }
            if (start2 != end2)
            {
                for (int i = start2; i < end2; i++)
                {
                    temp[position] = data[i];
                    position++;
                }
            }
            //  Console.WriteLine("adding this to data:");
            //foreach (int item in temp)
            //{
            //  Console.Write("{0}, ", item);
            //}
            //Console.WriteLine("");
            for (int i = left; i < right; i++)
            {
                data[i] = temp[i];
            }
        }



        public int[] Split(int[] data)
        {
            if (data.Length <= 1)
            {
                return data;
            }
            foreach (int item in data)
            {
                Console.WriteLine("{0} ", item);
            }
            int mid;
            mid = data.Length / 2;
            int[] leftList = new int[mid];
            for (int i = 0; i < leftList.Length; i++)
            {
                leftList[i] = data[i];
            }
            int[] rightList = new int[data.Length - mid];
            for (int i = 0; i < rightList.Length; i++)
            {
                rightList[i] = data[i + mid];
            }
            Console.WriteLine("Left is {0} long.", leftList.Length);
            Console.WriteLine("Right is {0} long.", rightList.Length);
            leftList = Split(leftList);
            rightList = Split(rightList);
            return Merge(leftList, rightList);
        }

        public int[] Merge(int[] left, int[] right)
        {
            List<int> leftList = left.OfType<int>().ToList();
            List<int> rightList = right.OfType<int>().ToList();
            List<int> resultList = new List<int>();

            while ((leftList.Count > 0) || (rightList.Count > 0))
            {
                if ((leftList.Count > 0) && (rightList.Count > 0))
                {
                    if (leftList[0] <= rightList[0])
                    {
                        resultList.Add(leftList[0]);
                        leftList.RemoveAt(0);
                    }
                    else
                    {
                        resultList.Add(rightList[0]);
                        rightList.RemoveAt(0);
                    }
                }
               else if (leftList.Count>0)
                {
                    resultList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }
                else if (rightList.Count > 0)
                {
                    resultList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }
            int[] resultArray = resultList.ToArray();
            return resultArray;
        }
    }
}
