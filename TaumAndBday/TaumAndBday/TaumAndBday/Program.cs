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
     * Complete the 'taumBday' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER b
     *  2. INTEGER w
     *  3. INTEGER bc
     *  4. INTEGER wc
     *  5. INTEGER z
     */

    public static long taumBday(int b, int w, int bc, int wc, int z)
    {
        long value = 0L;
        if (bc > wc && bc - wc > z)
        {
            value = ( ( (long)wc ) * ( (long)b + w ) + ( ( (long)b ) * z ) );


        }
        else if (bc < wc && wc - bc > z)
        {
            value = ( ( (long)bc ) * ( (long)b + w ) + ( ( (long)w ) * z ) );
        }
        else
        {
            value = ( (long)wc * w ) + ( (long)bc * b );
        }
        return value;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        int t = Convert.ToInt32(textReader.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = textReader.ReadLine().TrimEnd().Split(' ');

            int b = Convert.ToInt32(firstMultipleInput[0]);

            int w = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = textReader.ReadLine().TrimEnd().Split(' ');

            int bc = Convert.ToInt32(secondMultipleInput[0]);

            int wc = Convert.ToInt32(secondMultipleInput[1]);

            int z = Convert.ToInt32(secondMultipleInput[2]);

            long result = Result.taumBday(b, w, bc, wc, z);

            Console.WriteLine(result);
        }

        
        textReader.Close();
    }
}
