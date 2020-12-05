using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int counter = 0;
        foreach (var key in myDict)
            counter += 1;
        return counter;
    }
}
