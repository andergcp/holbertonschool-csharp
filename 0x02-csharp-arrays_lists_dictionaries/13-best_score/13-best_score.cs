using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string maxKey = "None";
        int maxValue = 0;
        foreach (var item in myList)
        {
            if (item.Value >= maxValue)
            {
                maxKey = item.Key;
                maxValue = item.Value;
            }
        }
        return maxKey;
    }
}
