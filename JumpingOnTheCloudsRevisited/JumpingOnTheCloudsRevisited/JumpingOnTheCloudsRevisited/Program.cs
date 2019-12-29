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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c, int k)
    {
        int currentEnergy = 100;
        int energyForJump = 1;
        int energyForThunderCloud = 2;
        int index = 0;
        while (( index + k ) % c.Length != 0)
        {
            currentEnergy-= energyForJump;
            if (c[(index + k)%c.Length] == 1)
            {
                currentEnergy -= energyForThunderCloud;
            }
            index = (index + k)%c.Length;
        }
        if (c[0] == 1)
        {
            currentEnergy -= energyForThunderCloud;
        }
        return --currentEnergy;
    }

    static void Main(string[] args)
    {
        TextReader textReader = new StreamReader(@"input.txt");

        string[] nk = textReader.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(textReader.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c, k);

        Console.WriteLine(result);

        
        textReader.Close();
    }
}
