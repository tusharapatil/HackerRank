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

class Solution
{
    static void DisplayArr(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    // Complete the insertionSort1 function below.
    static void insertionSort1(int n, int[] arr)
    {
        int lastElement = arr[arr.Length - 1];
        for (int i = arr.Length-1; i >= 0; i--)
        {
            if (i==0 || lastElement > arr[i-1])
            {
                arr[i] = lastElement;
                DisplayArr(arr);
                break;
            }
            else
            {
                arr[i] = arr[i-1];
                DisplayArr(arr);
            }
           
        }

    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");
        int n = Convert.ToInt32(textReader.ReadLine());

        int[] arr = Array.ConvertAll(textReader.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        insertionSort1(n, arr);
    }
}
