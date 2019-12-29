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

class Result
{

    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        foreach (var n in a)
        {
            if (numbers.ContainsKey(n))
            {
                numbers[n] = numbers[n] + 1;
            }
            else
            {
                numbers.Add(n, 1);
            }

        }
       var ordered = numbers.OrderBy(k => k.Key).ToArray();
        int max = int.MinValue;
        int maxSingle = int.MinValue;
        for (int i = 0; i < ordered.Length-1; i++)
        {
            if (maxSingle < ordered[i].Value)
            {
                maxSingle = ordered[i].Value;
            }
            int count = 0;
            if (ordered[i + 1].Key - ordered[i].Key == 1)
            {
                count = ordered[i + 1].Value + ordered[i].Value;
                if (count > max)
                {
                    max = count;
                }
            }
        }
        if (maxSingle < ordered[ordered.Length - 1].Value)
        {
            maxSingle = ordered[ordered.Length - 1].Value;
        }
        return max<maxSingle? maxSingle:max;
    }

}


class Solution
{
    
    public static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        int n = Convert.ToInt32(textReader.ReadLine().Trim());

        List<int> a = textReader.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        Console.WriteLine($"result:{result}");
        textReader.Close();
    }
}
