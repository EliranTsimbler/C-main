using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void printStars(int[] star)
        {
            for (int i = 0; i < star.Length; i++)
            {
                for (int j = 0; j < star[i]; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        static void printNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j <= numbers[i]; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void printReverseNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = numbers[i]; j > 0; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void reverseSquared(int[] numbers)
        {
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(Math.Pow(numbers[i], 2));
            }
        }

        //creates an array
        static int[] createAndReadArr(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter num " + (i + 1));
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        //prints an array.
        static void printArr(int[] arr)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            Console.WriteLine("}");
        }

        //gives you the max value of an array.
        static int maxGrade(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        //gives you the min value of an array.
        static int minGrade(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        //calculates the averge value of an array.
        static double averageValue(int[] arr)
        {
            double averge = 0;
            int count = 0;
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                count++;
            }

            averge = sum / count;
            return averge;
        }

        //ממוצה
        static int aboveAverage(int[] arr)
        {
            double averge = averageValue(arr);
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > averge)
                    count++;
            }
            return count;
        }

        //A function that cycles a number in an array by a given number.
        static int[] leftCycle(int[] arr, int cycles)
        {
            for(int i = 0;i < cycles;i++)
            {
                int temp = arr[0];
                for (int j = 0; j< arr.Length-1; j++)
                {
                    arr[j] = arr[j+1];
                }
                arr[arr.Length-1] = temp;
            }
            return arr;
        }


        //עזרא
        static bool HadAppearBefore(char[] arr, int index)
        {
            for(int i = 0; i < index; i++)
            {
                if (arr[index] == arr[i])
                    return true;               
            }
            return false;
        }

        static int PrintRemoveDups(char[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(!HadAppearBefore(arr, i))
                {
                    Console.Write(arr[i]);
                    Console.Write(" ");
                    count++;
                }
            }
            return count;
        }

        static int countUnique(char[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(!HadAppearBefore(arr, i))
                {
                    count++;
                }
            }
            return count;
        }

        static char[] CreateUnique(char[] arr, char[] arr1)
        {
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!HadAppearBefore(arr, i))
                {
                    arr1[j] = arr[i];
                    j++;
                }
            }
            return arr1;
        }

        static void CowData()
        {
            int sum = 0;         
            Random random = new Random();
            int cows = 3;
            int[] cowData = new int[cows];
            for(int i = 0;i < 30; i++)
            {
                for(int j = 0; j < cows; j++)
                {
                    //Console.WriteLine("enter cow data for cow "+ (j+1) + " in day " + (i+1));
                    //cowData[j] = int.Parse(Console.ReadLine());
                    cowData[j] = random.Next(cows);
                    sum += cowData[j];
                }
            }
            int average = sum / cows;

            Console.WriteLine("cows below averge: ");
            for (int i = 0; i< cowData.Length ; i++)
            {
                if (cowData[i] < average)
                    Console.Write(i+1+ " ,");
            }
        }

        static void Main(string[] args)
        {

            CowData();
        }
    }
}
