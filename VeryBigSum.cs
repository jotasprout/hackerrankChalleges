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
     * Complete the 'aVeryBigSum' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER_ARRAY ar as parameter.
     */

    public static long aVeryBigSum(List<long> ar)
    {
        var fatDollars = new List <System.Numerics.BigInteger>();           // create new empty list to hold big integers
        int arLength = ar.Count;                                            // Determine length of ar
        Console.WriteLine(arLength);                                        // tell me length of ar
        for (int i=0; i < arLength; i++){                                   // iterates over length of ar
            string fatInt = ar[i];                                          
            BigInteger BabyFatInt = BigInteger.Parse(fatInt);
            fatDollars.Add(BabyFatInt); // put babyFatInt into fatDollars
            BigInteger FatBabies = fatDollars.Aggregate(BigInteger.Add);
        }
        return FatBabies;
        Console.WriteLine(FatBabies);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

        long result = Result.aVeryBigSum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}