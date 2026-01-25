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
            for(int i =0; i< star.Length; i++)
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
                for(int j = 1 ; j <= numbers[i]; j++)
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
                for(int j = numbers[i]; j > 0; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void reverseSquared(int[] numbers)
        {
            for(int i =numbers.Length-1 ; i >= 0; i--)
            {
                Console.WriteLine(Math.Pow(numbers[i], 2)); 
            }
        }

        static int[] createAndReadArr(int size)
        {
            int[] arr = new int[size];
            for (int i = 0;i < size; i++)
            {
                Console.WriteLine("enter num " + (i+1));
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        static void printArr(int[] arr)
        {
            Console.Write("{");
            for(int i = 0; i < arr.Length ; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            Console.WriteLine("}");
        }
        
        static int maxGrade(int[] arr)
        {
            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if( arr[i] > max)
                    max = arr[i];
            }
            return max;
        }    
        
        static int minGrade(int[] arr)
        {
            int min = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if( arr[i] < min)
                    min = arr[i];
            }
            return min;
        }        

        static double avergeGrade(int[] arr)
        {
            double averge = 0;
            int count = 0;
            double sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                count++;
            }

            averge = sum / count;
            return averge;           
        }

        //ממוצה
        static int aboveAverge(int[] arr)
        {
            double averge = avergeGrade(arr);
            int count = 0;
            for(int i = 0;i < arr.Length; i++)
            {
                if(arr[i] > averge)
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            
            int[] arr = createAndReadArr(5);
            printArr(arr);
            Console.WriteLine("max grade is: "+ maxGrade(arr));
            Console.WriteLine("min grade is: "+ minGrade(arr));
            Console.WriteLine("averge is: " + avergeGrade(arr));
            Console.WriteLine("people with grade above averge: " + aboveAverge(arr));
        }
    }
}
