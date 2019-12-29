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

    // Complete the saveThePrisoner function below.
    static int saveThePrisoner(int n, int m, int s)
    {
        int remainder = m % n;
        int result = ( s + remainder -1) % n;
        return result> 0? result:n;
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        int t = Convert.ToInt32(textReader.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nms = textReader.ReadLine().Split(' ');

            int n = Convert.ToInt32(nms[0]);

            int m = Convert.ToInt32(nms[1]);

            int s = Convert.ToInt32(nms[2]);

            int result = saveThePrisoner(n, m, s);

            Console.WriteLine(result);
        }

        
        textReader.Close();
    }
}
