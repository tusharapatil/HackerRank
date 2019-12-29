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
using System.Numerics;

class Solution
{
    public static string ToBinaryString( BigInteger bigint)
    {
        var bytes = bigint.ToByteArray();
        var index = bytes.Length - 1;
        var base2 = new StringBuilder(bytes.Length * 8);
        var binary = Convert.ToString(bytes[index], 2);
        if (binary[0] != '0' && bigint.Sign == 1)
            base2.Append('0');
        base2.Append(binary);
        for (index--; index >= 0; index--)
            base2.Append(Convert.ToString(bytes[index], 2).PadLeft(8, '0'));
        return base2.ToString();
    }

    // Complete the acmTeam function below.
    static int[] acmTeam(string[] topic)
    {
        int max = int.MinValue;
        int count = 0;
        for (int i = 0; i < topic.Length; i++)
        {
            for (int j = i+1; j < topic.Length; j++)
            {
                int temp = 0;
                for (int k = 0; k < topic[i].Length; k++)
                {
                    if (topic[i][k] == '1' || topic[j][k] == '1')
                    {
                        temp++;
                    }
                }
                if (temp > max)
                {
                    max = temp;
                    count = 1;
                }
                else if (temp == max)
                {
                    count++;
                }
            }
        }
        var output =new int[] { max, count };
       // output[0] = result.Max();
       // output[1] = result.Count(k=> k== output[0]);
        return output;
    }

    static void Main(string[] args)
    {
        string s = ToBinaryString(new BigInteger(256));
        TextReader textReader = new StreamReader(@"input.txt");

        string[] nm = textReader.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        string[] topic = new string[n];

        for (int i = 0; i < n; i++)
        {
            string topicItem = textReader.ReadLine();
            topic[i] = topicItem;
        }

        int[] result = acmTeam(topic);

        Console.WriteLine(string.Join("\n", result));

        
        textReader.Close();
    }
}
