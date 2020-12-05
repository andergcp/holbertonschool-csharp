using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        var resultList = new List<bool>();
        foreach (int number in myList)
        {
            bool ans = number % 2 == 0 ? true : false;
            resultList.Add(ans);
        }
        return resultList;
    }
}
