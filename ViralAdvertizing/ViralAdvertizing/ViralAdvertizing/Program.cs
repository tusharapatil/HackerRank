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

    // Complete the viralAdvertising function below.
    static int viralAdvertising(int n)
    {
        int recipients = 5;
        int likes = 0;
       
        for (int i = 0; i < n; i++)
        { int peopleLikes = Convert.ToInt32(Math.Floor((decimal)recipients / 2));
            likes += peopleLikes;
            recipients = peopleLikes * 3;
        }
        return likes;
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        int n = Convert.ToInt32(textReader.ReadLine());

        int result = viralAdvertising(n);

        Console.WriteLine(result);

       
        textReader.Close();
    }
}
