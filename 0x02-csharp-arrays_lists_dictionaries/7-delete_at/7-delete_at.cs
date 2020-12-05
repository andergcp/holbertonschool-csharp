using System;
using System.Collections.Generic;


class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        int len = myList.Count;
        if (index < 0 || index >= len)
            Console.WriteLine("Index is out of range");
        else
            for (int i = index; i < len; i++)
            {
                if (i + 1 < len)
                    myList[i] = myList[i + 1];
                else
                    myList.RemoveRange(i - 1, 1);
            }
        return myList;
    }
}
