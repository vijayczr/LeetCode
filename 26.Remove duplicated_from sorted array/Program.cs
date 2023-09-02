using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

public class Result
{

    /*
     * Complete the 'stringConstruction' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */
    public int RemoveDuplicates(int[] nums)
    {
        int j = 1;
        foreach (var x in nums)
        {
            if (nums[j - 1] != x)
            {
                nums[j] = x;
                j++;
            }
        }
        return j;
    }


}

class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of array!");
        int x  = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an sorted array!");
        var nums = new int[x];
        for(int i = 0; i < x; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        var g = new Result();
        int m = g.RemoveDuplicates(nums);
        for(int j = 0; j < m; j++)
        {
            Console.Write(nums[j] + " ");
        }



        //int RemoveDuplicates(int[] nums)
        //{
        //    int j = 1;
        //    foreach (var x in nums)
        //    {
        //        if (nums[j - 1] != x)
        //        {
        //            nums[j] = x;
        //            j++;
        //        }
        //    }
        //    return j;
        //}
    }


}