﻿using System.CodeDom.Compiler;
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

    // Complete the squares function below.
    static int squares(int a, int b)
    {
        int count =(int)( Math.Floor(Math.Sqrt(b)) - Math.Ceiling(Math.Sqrt(a)) +1);
      
        return count;
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        int q = Convert.ToInt32(textReader.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] ab = textReader.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            int result = squares(a, b);

            Console.WriteLine(result);
        }

        
        textReader.Close();
    }
}
