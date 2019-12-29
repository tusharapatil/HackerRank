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

    // Complete the serviceLane function below.
    static int[] serviceLane(int n, int[][] cases,int[] width)
    {
        int[] result = new int[cases.GetLength(0)];
        for (int i = 0; i < cases.GetLength(0); i++)
        {
            int min = int.MaxValue;
            for (int j = cases[i][0]; j <= cases[i][1]; j++)
            {
                if (min > width[j])
                {
                    min = width[j];
                }
            }
            result[i] = min;
        }
        return result;
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        string[] nt = textReader.ReadLine().Split(' ');

        int n = Convert.ToInt32(nt[0]);

        int t = Convert.ToInt32(nt[1]);

        int[] width = Array.ConvertAll(textReader.ReadLine().Split(' '), widthTemp => Convert.ToInt32(widthTemp))
        ;

        int[][] cases = new int[t][];

        for (int i = 0; i < t; i++)
        {
            cases[i] = Array.ConvertAll(textReader.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
        }

        int[] result = serviceLane(n, cases,width);

        Console.WriteLine(string.Join("\n", result));

        
        textReader.Close();
    }
}
