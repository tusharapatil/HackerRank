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

    // Complete the equalizeArray function below.
    static int equalizeArray(int[] arr)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        int max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (dictionary.ContainsKey(arr[i]))
            {
                dictionary[arr[i]] += 1; 
                
            }
            else
            {
                dictionary.Add(arr[i], 1);
            }
            if (dictionary[arr[i]] > max)
            {
                max = dictionary[arr[i]];
            }
        }
        return arr.Length - max;
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        int n = Convert.ToInt32(textReader.ReadLine());

        int[] arr = Array.ConvertAll(textReader.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = equalizeArray(arr);

        Console.WriteLine(result);

        
        textReader.Close();
    }
}
