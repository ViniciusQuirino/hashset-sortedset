using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6, 8, 10 };
        SortedSet<int> b = new SortedSet<int>() { 5, 7, 9, 6, 8 };

        //union
        SortedSet<int> c = new SortedSet<int>(a);
        // c.UnionWith(b);
        printCollection(c);

        //difference
        SortedSet<int> e = new SortedSet<int>(a);
        e.ExceptWith(b);
        printCollection(e);

        //intersectiond
        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b);
        printCollection(d);

    }

    static void printCollection<T>(IEnumerable<T> collection)
    {
        foreach (T obj in collection)
        {
            Console.Write(obj + " ");
        }
        Console.WriteLine();
    }
}
