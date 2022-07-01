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
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */
    

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> aliceAwards = new List<int>();
        List<int> bobAwards = new List<int>();
        
        int alicePoints = 0;
        int bobPoints = 0;
        
        for(int i = 0; i < a.Count; i++){
            if (a[i] > b[i]){
                aliceAwards.Add(1);
            }
            else if (a[i] < b[i]){
                bobAwards.Add(1);
            }
        }

        alicePoints = aliceAwards.Sum();
        bobPoints = bobAwards.Sum();

        // int[] comparisonPoints = new int[2];
        // comparisonPoints = [alicePoints, bobPoints];
        // int[] comparisonPoints = new int[] {alicePoints, bobPoints};
        List<int> comparisonPoints = new List<int>() {alicePoints, bobPoints};
        //List<int> comparisonPoints = new List<int>();
        //comparisonPoints.Add(alicePoints);
        //comparisonPoints.Add(bobPoints);
        return comparisonPoints;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}