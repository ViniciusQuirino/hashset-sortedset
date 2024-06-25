using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> set = new HashSet<string>();
        set.Add("TV");
        set.Add("Notebook");
        set.Add("Tablet");
        Console.WriteLine(set.Contains("Computer"));
        foreach (String p in set)
        {
            Console.WriteLine(p);
        }
    }
}
