using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RoughFile
{
    public class Result
    {
        // Complete the birthdayCakeCandles function below.
        static int birthdayCakeCandles(int[] ar)
        {
            Dictionary<int, int> candles = new Dictionary<int, int>();
            //int count = 0;
            foreach(var item in ar)
            {
                if (candles.ContainsKey(item))
                {
                    candles.TryGetValue(item, out int count);
                    count += 1;
                    candles[item] = count;
                }
                else
                {
                    int new_item = 1;
                    candles.Add(item, new_item);
                }
            }
            Console.WriteLine(candles.Values.Max());
            return candles.Values.Max();
        }

        static void Main(string[] args)
        {
            System.Environment.SetEnvironmentVariable("OUTPUT_PATH", "1");
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = birthdayCakeCandles(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}

//-------------------------------------------------------------------------------------------------- *
//-----------------------------CONCATENATION/ADDITION ---------------------------------------------- *
//-------------------------------------------------------------------------------------------------- *
//int i = 4;
//double d = 4.0;
//string s = "HackerRank ";
// Declare second integer, double, and String variables.
//int a;
//double b;
//string c;
//// Read and save an integer, double, and String to your variables.
//int.TryParse(Console.ReadLine(), out a);
//b = Convert.ToDouble(Console.ReadLine());
//            //double.TryParse(Console.ReadLine(),out b);
//            c = Console.ReadLine();
//            // Print the sum of both integer variables on a new line.
//            Console.WriteLine(i + a);


//            // Print the sum of the double variables on a new line.
//            Console.WriteLine("{0:F1}",d+b);
//            // Concatenate and print the String variables on a new line
//            // The 's' variable above should be printed first.
//            Console.WriteLine(s + c);

//-------------------------------------------------------------------------------------------------- *
//*--------------------------------TOTAL BILL AMOUINT CALCULATION ---------------------------------- *
//-------------------------------------------------------------------------------------------------- *
//static void Main(string[] args)
//{
//    double meal_cost = Convert.ToDouble(Console.ReadLine());

//    int tip_percent = Convert.ToInt32(Console.ReadLine());

//    int tax_percent = Convert.ToInt32(Console.ReadLine());
//    //Console.WriteLine(Convert.ToDouble(20)/100);

//    solve(meal_cost, tip_percent, tax_percent);
//}
//static void solve(double meal_cost, int tip_percent, int tax_percent)
//{
//    double tip = meal_cost * Convert.ToDouble(tip_percent) / 100;
//    double tax = meal_cost * Convert.ToDouble(tax_percent) / 100;
//    Console.WriteLine(Convert.ToInt32(meal_cost+tip+tax));
//}
//-------------------------------------------------------------------------------------------------- *
//---------------------------- SUM OF ARRAY ELEMENTS ----------------------------------------------- *
//-------------------------------------------------------------------------------------------------- *
//static int simpleArraySum(int[] ar)
//{
//    /*
//    * Write your code here.
//    */
//    int result = 0;
//    foreach (var item in ar)
//    {
//        result += item;
//    }
//    return result;
//}

//static void Main(string[] args)
//{
//    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
//    Console.WriteLine("Enter Array Length");
//    int arCount = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Enter array elements separated with space, eg: 2 3 4");
//    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
//    ;
//    int result = simpleArraySum(ar);

//    textWriter.WriteLine(result);

//    textWriter.Flush();
//    textWriter.Close();
//}

//-------------------------------------------------------------------------------------------------- *
//*--------------------------------------COMPARE TRIPLETS------------------------------------------- *
//-------------------------------------------------------------------------------------------------- *
// Complete the compareTriplets function below.
//   static List<int> compareTriplets(List<int> a, List<int> b)
//    {
//        List<int> scoreBoard = new List<int>();
//        int sb1 = 0;
//        int sb2 = 0;
//        for(int i = 0; i < a.Count(); i++)
//        {
//            if(a[i] > b[i])
//            {
//                sb1+= 1 ;

//            }
//            else if(a[i] < b[i])
//            {
//                sb2 += 1;
//            }
//        }
//        scoreBoard.Add(sb1);
//        scoreBoard.Add(sb2);
//        return scoreBoard;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

//        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

//        List<int> result = compareTriplets(a, b);

//        textWriter.WriteLine(String.Join(" ", result));

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}

//-------------------------------------------------------------------------------------------------- *
//*---------------------------------SUM OF BIG NUMBERS IN ARRAY------------------------------------- *
//-------------------------------------------------------------------------------------------------- *
//static long aVeryBigSum(long[] ar)
//{
//    long result = 0;
//    foreach (var item in ar)
//    {
//        result += item;
//    }
//    return result;
//}

//static void Main(string[] args)
//{
//    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//    int arCount = Convert.ToInt32(Console.ReadLine());

//    long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
//    ;
//    long result = aVeryBigSum(ar);

//    textWriter.WriteLine(result);

//    textWriter.Flush();
//    textWriter.Close();
//}

//-------------------------------------------------------------------------------------------------- *
//*---------------------------------SUM OF BOTH DIAGONALS IN ARRAY---------------------------------- *
//-------------------------------------------------------------------------------------------------- *
//public static void Main(string[] args)
//{
//    System.Environment.SetEnvironmentVariable("OUTPUT_PATH", "1");
//    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//    int n = Convert.ToInt32(Console.ReadLine().Trim());

//    List<List<int>> arr = new List<List<int>>();

//    for (int i = 0; i < n; i++)
//    {
//        arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
//    }

//    int result = Result.diagonalDifference(arr);

//    textWriter.WriteLine(result);

//    textWriter.Flush();
//    textWriter.Close();
//}
//public static int diagonalDifference(List<List<int>> arr)
//{
//    int row_count = arr.Count();
//    int col_count = arr[0].Count();
//    List<int> diagonal1 = new List<int>();
//    List<int> diagonal2 = new List<int>();
//    for (int i = 0; i < row_count; i++)
//    {
//        diagonal1.Add(arr[i][i]);
//        diagonal2.Add(arr[i][col_count - 1]);
//        col_count--;
//    }
//    int diff = diagonal1.Sum(i => i) - diagonal2.Sum(j => j);
//    return System.Math.Abs(diff);
//}

//-------------------------------------------------------------------------------------------------- *
//*------------------------FRACTION OF POSITIVE,NEGATIVE,ZERO NUM IN ARRAY-------------------------- *
//-------------------------------------------------------------------------------------------------- *
//static void plusMinus(int[] arr)
//{
//    double positive = 0;
//    double negative = 0;
//    foreach (var item in arr)
//    {
//        if (item > 0)
//        {
//            positive += 1;
//        }
//        if (item < 0)
//        {
//            negative += 1;
//        }
//    }
//    Console.WriteLine(Math.Round((positive / arr.Length), 6));
//    Console.WriteLine(Math.Round((negative / arr.Length), 6));
//    Console.WriteLine("{0:F6}", Convert.ToDouble(arr.Length - positive - negative) / arr.Length);
//}

//static void Main(string[] args)
//{
//    int n = Convert.ToInt32(Console.ReadLine());

//    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
//    ;
//    plusMinus(arr);
//}

//-------------------------------------------------------------------------------------------------- *
//*---------------------------PRINT A STAIRCASE FORMAT FOR GIVEN LENGTH----------------------------- *
//-------------------------------------------------------------------------------------------------- *

// Complete the staircase function below.
//static void staircase(int n)
//{

//    for (int i = 1; i <= n; i++)
//    {
//        for (int j = 1; j <= n; j++)
//        {
//            if (j <= n - i)
//            {
//                Console.Write(" ");
//            }
//            else
//            {
//                Console.Write("#");
//            }
//        }
//        Console.WriteLine();
//    }

//}

//static void Main(string[] args)
//{
//    int n = Convert.ToInt32(Console.ReadLine());
//    staircase(n);
//}


//-------------------------------------------------------------------------------------------------- *
//*------------------------------MINI & MAX SUM OF ARRAY OF ELEMENTS-------------------------------- *
//-------------------------------------------------------------------------------------------------- *
//static void miniMaxSum(int[] arr)
//{
//    long[] arr_converted = Array.ConvertAll<int, long>(arr, item => item);
//    long max_sum = arr.Sum() - arr.Min();
//    long mini_sum = arr.Sum() - arr.Max();
//    Console.WriteLine($"{mini_sum} {max_sum}");
//}

//static void Main(string[] args)
//{
//    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
//    ;
//    miniMaxSum(arr);
//}