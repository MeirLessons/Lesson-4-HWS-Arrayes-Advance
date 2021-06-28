using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_HWS_Arrays_Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Qst 1

            //int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int curTries = 0, sumTries = 0;
            //for (int i = 0; i < intArr.Length; i++)
            //{
            //    while (sumTries + curTries < 30)
            //    {
            //        int num = int.Parse(Console.ReadLine());
            //        curTries++;
            //        if (Array.IndexOf(intArr,num) == i)
            //        {
            //            Console.WriteLine($"You Found Item {i+1} After: {curTries} Tries");
            //            sumTries += curTries;
            //            curTries = 0;
            //            break;
            //        }
            //        else
            //            Console.WriteLine("Try Again");
            //    }

            //    if (sumTries + curTries >= 30)
            //    {
            //        Console.WriteLine("Game Over");
            //        break;
            //    }
            //}

            #endregion

            #region Qst 3
            int[,] twoDimIntArr = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < twoDimIntArr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimIntArr.GetLength(1); j++)
                {
                    twoDimIntArr[i, j] = rnd.Next();
                }
            }

            int num1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < twoDimIntArr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimIntArr.GetLength(1); j++)
                {
                    if(twoDimIntArr[i, j] == num1)
                    {
                        Console.WriteLine($"i = {i}. j = {j}");
                    }
                }
            }

            #endregion
            #region Qst 7

            string[,] strArr = new string[6, 4]
            {
                { "*","*","*","*"},
                { "*","*","*","*"},
                { "*","*","*","*"},
                { "*","*","*","*"},
                { "*","*","*","*"},
                { "*","*","*","*"}
            };

            for (int i = 0; i < strArr.GetLength(0); i++)
            {
                for (int j = 0; j < strArr.GetLength(1); j++)
                {
                    Console.Write(strArr[i, j]);
                }
                Console.WriteLine();
            }

            #endregion

            #region Classes With Students

            Console.WriteLine("Please Enter Num Of Classes:");
            int classes = int.Parse(Console.ReadLine());
            int[][] classesArray = new int[classes][];
            int sizeOfCurrentClass;
            Random rnd1 = new Random();
            for (int i = 0; i < classesArray.Length; i++)
            {
                Console.WriteLine("Enter Size For Current Class:");
                sizeOfCurrentClass = int.Parse(Console.ReadLine());
                classesArray[i] = new int[sizeOfCurrentClass];
                for (int j = 0; j < sizeOfCurrentClass; j++)
                {
                    classesArray[i][j] = rnd1.Next(0, 101);
                    Console.WriteLine(classesArray[i][j] +  " ");
                }
            }
            int curSum, maxAvg = 0, maxIndex = 0;
            for (int i = 0; i < classesArray.Length; i++)
            {
                curSum = 0;
                for (int j = 0; j < classesArray[i].Length; j++)
                {
                    curSum += classesArray[i][j];
                }
                if (curSum / classesArray[i].Length > maxAvg)
                {
                    maxAvg = curSum / classesArray[i].Length;
                    maxIndex = i;
                }
            }
            Console.WriteLine("Higher Avg({0}) Its Of Class Number: {1}",maxAvg,maxIndex);
            #endregion
        }
    }
}
