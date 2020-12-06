using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var listKeys = myDict.Keys.ToList();
        listKeys.Sort();

        foreach (var key in listKeys)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}
