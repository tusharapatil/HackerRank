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

    // Complete the workbook function below.
    static int workbook(int n, int k, int[] arr)
    {
        int pageNumber = 1;
        int magicNumber = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int j = 1;
            for ( j = 1; j <= arr[i]; j++)
            {
                if (pageNumber == j)
                    magicNumber++;
                if (j % k == 0)
                    pageNumber++;
            }
            if ((j-1) % k != 0)
            {

                pageNumber++;
            }
        }
        return magicNumber;
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        string[] nk = textReader.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] arr = Array.ConvertAll(textReader.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = workbook(n, k, arr);

        Console.WriteLine(result);


        textReader.Close();
    }
}
