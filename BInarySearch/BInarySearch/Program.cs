using System;
using System.Collections.Generic;

namespace BinarySearch
{
    class BinarySearch
    {
         public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            int f = 0;
            int l = list.Count-1;
            int toFind = 1;
            int found = Searching(list, f, l, toFind);
            if(found == -1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("The item is at " + found);
            }
        }

        public static int  Searching(List<int> list,int first,int last,int x)
        {

            if (first <= last)
            {
                int mid = (first + last) / 2;
                if (list[mid] == x)
                {
                    return mid;
                }
                else if (list[mid] < x)
                {

                    return Searching(list, mid + 1, last, x);
                }
                else if (list[mid] > x)
                {
                    return Searching(list, first, mid - 1, x);
                }
            }
            return -1;
            
        }
    }
}
