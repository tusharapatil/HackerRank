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

    // Complete the beautifulDays function below.
    static int beautifulDays(int i, int j, int k)
    {
        int count = 0;
        for (int x = i; x <= j; x++)
        {
            string number = x.ToString();
            string reverseNumber = new string(number.Reverse().ToArray());
            int reverseNum = Convert.ToInt32(reverseNumber);
            int diff = Math.Abs(x - reverseNum);
            if (diff % k == 0)
            {
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        string[] ijk = textReader.ReadLine().Split(' ');

        int i = Convert.ToInt32(ijk[0]);

        int j = Convert.ToInt32(ijk[1]);

        int k = Convert.ToInt32(ijk[2]);

        int result = beautifulDays(i, j, k);

        Console.WriteLine(result);

        
        textReader.Close();
    }
}
