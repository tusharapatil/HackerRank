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

    // Complete the happyLadybugs function below.
    static string happyLadybugs(string b)
    {


    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        int g = Convert.ToInt32(textReader.ReadLine());

        for (int gItr = 0; gItr < g; gItr++)
        {
            int n = Convert.ToInt32(textReader.ReadLine());

            string b = textReader.ReadLine();

            string result = happyLadybugs(b);

            Console.WriteLine(result);
        }

        
        textReader.Close();
    }
}
