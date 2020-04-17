using System;

namespace MenorMasCercano
{
    class Program
    {
        public static string NearestSmallerValues(int[] arr)
        {

            // code goes here

            var result = "-1 ";
            for (int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                for (int j = i - 1; j == 0; j--)
                {
                    Console.WriteLine("j = " + j + " i = " + i);
                    if (arr[j] < arr[i])
                    {
                        result = result + arr[j] + " ";
                        break;
                    }
                    result = result + "-1 ";
                    Console.WriteLine("Pase");
                }
            }

            return result;

        }
        static void Main(string[] args)
        {
            var entrada = new int[] { 5, 3, 1, 5, 5, 8 };
            Console.WriteLine(NearestSmallerValues(entrada));
        }
    }
}
