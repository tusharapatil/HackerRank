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

    // Complete the permutationEquation function below.
    static int[] permutationEquation(int[] p)
    {
        int[] result = new int[p.Length];
        for (int i = 0; i < p.Length; i++)
        {
            int index = Array.IndexOf(p, i + 1);
            int index2 = Array.IndexOf(p, index+1);
            result[i] = index2 + 1;
        }
        return result;
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        int n = Convert.ToInt32(textReader.ReadLine());

        int[] p = Array.ConvertAll(textReader.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp))
        ;
        int[] result = permutationEquation(p);

        Console.WriteLine(string.Join("\n", result));

        
        textReader.Close();
    }
}
