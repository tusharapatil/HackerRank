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
    // Complete the insertionSort2 function below.
    static void insertionSort2(int n, int[] arr)
    {
        int shift = 0;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
                shift++;
            }
            arr[j + 1] = key;
            DisplayArr(arr);
        }
        Console.WriteLine($"shift {shift}");
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");
        int n = Convert.ToInt32(textReader.ReadLine());

        int[] arr = Array.ConvertAll(textReader.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        insertionSort2(n, arr);
    }
}
