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

    // Complete the angryProfessor function below.
    static string angryProfessor(int k, int[] a)
    {
        int lateCount = a.Count(p => p > 0);
        if (a.Length - lateCount < k)
        {
            return "YES";

        }
        else
        {
            return "NO";
        }

    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        int t = Convert.ToInt32(textReader.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nk = textReader.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] a = Array.ConvertAll(textReader.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            string result = angryProfessor(k, a);

            Console.WriteLine(result);
        }


        textReader.Close();
    }
}
