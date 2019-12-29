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
using System.Threading.Tasks;

class Solution
{

    // Complete the flatlandSpaceStations function below.
    static int flatlandSpaceStations(int n, int[] c)
    {
      
          if (n == c.Length)
              return 0;
        int max = int.MinValue;
        if (c.Length != 1)
        {

            Array.Sort(c);
            
            for (int i = 0; i < c.Length - 1; i++)
            {
                int distance = c[i + 1] - c[i];
                if (distance > max)
                {
                    max = distance;
                }
            }
        }
        max = Convert.ToInt32(Math.Floor((Decimal)max / 2));
        if (c[0] > max)
        {
            max = c[0];
        }
        if (( n - 1 ) - c[c.Length - 1] > max)
        {
            max = ( n - 1 ) - c[c.Length - 1];
        }

          return max;
    
        
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        string[] nm = textReader.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] c = Array.ConvertAll(textReader.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        stopwatch.Start();
        int result =  flatlandSpaceStations(n, c);
        stopwatch.Stop();

        Console.WriteLine($" time : {stopwatch.ElapsedMilliseconds}   {result}");

        
        textReader.Close();
    }
}
