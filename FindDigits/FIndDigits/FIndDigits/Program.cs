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

    // Complete the findDigits function below.
    static int findDigits(int n)
    {
        int count = 0;
        int input = n;
        while (n > 0)
        {
            int remainder = n % 10;
            if (remainder != 0)
            {
                if (input % remainder == 0)
                {
                    count++;
                }
            }
            n = n / 10;
        }
        return count;
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        int t = Convert.ToInt32(textReader.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(textReader.ReadLine());

            int result = findDigits(n);

            Console.WriteLine(result);
        }

        
        textReader.Close();
    }
}
