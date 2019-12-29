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

    // Complete the chocolateFeast function below.
    static int chocolateFeast(int n, int c, int m)
    {
        int chocoCount = n / c;
        int wrapper = chocoCount;
        while (wrapper >= m)
        {
            chocoCount += wrapper / m;
            wrapper = wrapper % m + wrapper / m;
        }
        return chocoCount;
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        int t = Convert.ToInt32(textReader.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] ncm = textReader.ReadLine().Split(' ');

            int n = Convert.ToInt32(ncm[0]);

            int c = Convert.ToInt32(ncm[1]);

            int m = Convert.ToInt32(ncm[2]);

            int result = chocolateFeast(n, c, m);

            Console.WriteLine(result);
        }

        
        textReader.Close();
    }
}
