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

    // Complete the alternatingCharacters function below.
    static int alternatingCharacters(string s)
    {
        char firstOcc = s[0];
        int count = 0;
        for (int i = 1; i < s.Length; i++)
        {
            if (firstOcc == s[i])
            {
                count++;
            }
            else
            {
                firstOcc = s[i];
            }
        }

        return count;
    }

    static void Main(string[] args)
    {


        Console.WriteLine(str ==str1);
        Console.WriteLine(str == str2);
        TextReader textReader = new StreamReader(@"input.txt");

        int q = Convert.ToInt32(textReader.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = textReader.ReadLine();

            int result = alternatingCharacters(s);

            Console.WriteLine(result);
        }

        
        textReader.Close();
    }
}
