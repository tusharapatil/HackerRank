
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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {
        int startIndex = 0;
        int jumpCount = 0;
        while (startIndex != c.Length - 1)
        {
            if (startIndex + 2 < c.Length && c[startIndex + 2] == 0)
            {
                startIndex += 2;
            }
            else if (c[startIndex + 1] == 0)
            {
                startIndex +=1;
            }
            jumpCount++;
        }
        return jumpCount;
    }

    static void Main(string[] args)
    {

        TextReader textReader = new StreamReader("input.txt");

        int n = Convert.ToInt32(textReader.ReadLine());

        int[] c = Array.ConvertAll(textReader.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c);

        Console.WriteLine($"Result :{result}");

  
        textReader.Close();
        Console.ReadLine();
    }
}

