﻿namespace Pjjatk_1;

class Program
{
    static void Main(string[] args)
    {
        int[] tbl = { 1, 2, 3, 4, 5 };
        int[] hotfix = { 2, 3, 4, 5, 5 };
        var max = tbl.Max();
        Console.WriteLine(AverageFromArr(tbl));
    }

    static double AverageFromArr(int[] arr)
    {
        return arr.Average();
    }

    static int MaxIntFromArr(int[] arr)
    {
        int x = 0;
        //
        //To do something
        //
        foreach (var i in arr)
        {
            if (x < i)
            {
                x = i;
            }
        }

        return x;
    }
}