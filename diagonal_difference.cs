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

class Solution {

    // Complete the diagonalDifference function below.


    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());
        int right_d=0;
        int left_d=0;
        int difference=0;
        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        for(int i=0;i<n;i++)
        {
            right_d+=arr[i][i];
        }
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(i+j==n-1)
                {
                    left_d+=arr[i][j];
                }
            }
        }
        //nt result = diagonalDifference(arr);


         difference=Math.Abs(right_d-left_d);
        textWriter.WriteLine(difference);
        //textWriter.WriteLine(left_d);
        textWriter.Flush();
        textWriter.Close();
    }
}
