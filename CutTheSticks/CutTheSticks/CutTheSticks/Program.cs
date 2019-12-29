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

    // Complete the cutTheSticks function below.
    static int[] cutTheSticks(int[] arr)
    {
        List<int> result = new List<int>();
       // Array.Sort(arr);
        int count = arr.Length;

        while (count != 0)
        {
            result.Add(arr.Count(k => k > 0));
            int min = arr.Where(k=> k >0).Min();

            var minusMin = arr.Select(k => k - min).ToArray();
            
            arr = minusMin;
            count = arr.Count(k => k > 0);
        }

        return result.ToArray();
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        int n = Convert.ToInt32(textReader.ReadLine());

        int[] arr = Array.ConvertAll(textReader.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = cutTheSticks(arr);

        Console.WriteLine(string.Join("\n", result));

      
        textReader.Close();
    }
}