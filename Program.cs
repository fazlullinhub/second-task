using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            Random rand = new Random();

           
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }

            
            Console.WriteLine("You got array: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            
            int[] oneDimArr = new int[25];
            int z = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    oneDimArr[z] = arr[i, j];
                    z++;
                }

            Console.WriteLine("\nArray is converted to one dimensional:");
            foreach (int item in oneDimArr)
            {
                Console.Write(item + " ");
            }

            
            int min = oneDimArr[0];
            int max = oneDimArr[0];
            int indexMin = 0;
            int indexMax = 0;

            for (int i = 0; i < oneDimArr.Length; i++)
            {
                if (oneDimArr[i] < min)
                {
                    min = oneDimArr[i];
                    indexMin = i;
                }
                if (oneDimArr[i] > max)
                {
                    max = oneDimArr[i];
                    indexMax = i;
                }
            }

            Console.WriteLine("\n\nMax value: " + max);
            Console.WriteLine("Min value: " + min);

   
            int sum = 0;
            if (indexMin < indexMax)
            {
                for (int i = indexMin; i <= indexMax; i++)
                    sum += oneDimArr[i];
            }
            else
            {
                for (int i = indexMax; i <= indexMin; i++)
                    sum += oneDimArr[i];
            }

            Console.WriteLine("min = {0}, max = {1}, sum = {2}", min, max, sum);
            Console.ReadLine();
        }
    }
}

   
