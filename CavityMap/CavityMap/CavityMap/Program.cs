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

    // Complete the cavityMap function below.
    static string[] cavityMap(string[] grid)
    {
        
        string[] resultGrid = (string[])grid.Clone();
        for (int i = 1; i < grid.Length-1; i++)
        {
            for (int j = 1; j < grid[i].Length -1; j++)
            {
                int currentValue = Convert.ToInt32(grid[i][j]);
                if (currentValue > Convert.ToInt32(grid[i - 1][j]) &&
                   currentValue > Convert.ToInt32(grid[i + 1][j]) &&
                   currentValue > Convert.ToInt32(grid[i][j - 1]) &&
                   currentValue > Convert.ToInt32(grid[i][j + 1])
                    )
                {
                   var tempArr =  resultGrid[i].ToArray();
                    tempArr[j] = 'X';
                    resultGrid[i] = new string(tempArr);
                }

            }
        }
        return resultGrid;

    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        int n = Convert.ToInt32(textReader.ReadLine());

        string[] grid = new string[n];

        for (int i = 0; i < n; i++)
        {
            string gridItem = textReader.ReadLine();
            grid[i] = gridItem;
        }

        string[] result = cavityMap(grid);

        Console.WriteLine(string.Join("\n", result));

        
        textReader.Close();
    }
}
