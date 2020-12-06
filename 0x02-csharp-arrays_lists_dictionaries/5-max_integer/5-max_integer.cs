using System;
using System.Collections.Generic;


class List
{
    public static int MaxInteger(List<int> myList)
    {
        int len = myList.Count;
        if (myList == null || len == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        else
        {
            int max = 0;
            for (int i = 0; i < len; i++)
            {
                if (myList[i] > max)
                    max = myList[i];
            }
            return max;
        }
    }
}
