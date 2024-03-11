namespace Pjjatk_1;

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
        int sum = 0;
        foreach (var i in arr)
        {
            sum += i;
        }

        var arrLength = sum / arr.Length;
        if (arrLength == arr.Average())
        {
            return arrLength;
        }
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

    static int AverageNormal(int[] arr)
    {
        int sum = 0;
        foreach (var i in arr)
        {
            sum += i;
        }

        return sum / arr.Length;
    }
}