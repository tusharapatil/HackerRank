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

    // Complete the isValid function below.
    static string isValid(string s)
    {
        Dictionary<char, int> charDict = new Dictionary<char, int>();
        foreach (var ch in s)
        {
            if (charDict.ContainsKey(ch))
            {
                charDict[ch] += 1;
            }
            else
            {
                charDict.Add(ch, 1);
            }
        }
        int min = charDict.Min(k => k.Value);
        int max = charDict.Max(k => k.Value);

        if (min == max)
            return "YES";
        int minCount = charDict.Count(k => k.Value == min);
        
        int maxCount = charDict.Count(k => k.Value == max);
        if ((minCount == charDict.Count - 1 && max - min == 1) || ( maxCount == charDict.Count - 1 && (max - min == 1 || min==1) ))
        {
            return "YES";
        }
        else
        {
            return "NO";
        }

    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        string s = textReader.ReadLine();

        string result = isValid(s);

        Console.WriteLine(result);

        
        textReader.Close();
    }
}
