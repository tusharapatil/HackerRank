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

    // Complete the funnyString function below.
    static string funnyString(string s)
    {
        
        int[] strArr = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            strArr[i] = (int)s[i];
        }
        int[] reverseArr = strArr.Reverse().ToArray();
        for (int i = 0; i < strArr.Length-1; i++)
        {
            if (Math.Abs(strArr[i] - strArr[i + 1]) == Math.Abs(reverseArr[i] - reverseArr[i + 1]))
            {
                continue;
            }
            else
            {
                return "Not Funny";
            }
        }
        return "Funny";
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        int q = Convert.ToInt32(textReader.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = textReader.ReadLine();

            string result = funnyString(s);

            Console.WriteLine(result);
        }

        
        textReader.Close();
    }
}
