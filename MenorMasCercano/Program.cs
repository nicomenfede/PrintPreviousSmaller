using System;

namespace MenorMasCercano
{
    class Program
    {
        public static string NearestSmallerValues(int[] arr)
        {

            // code goes here
            var prevSmall = -1;
            var result = "-1 ";
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i-1] < arr[i])
                {
                    result += arr[i - 1] + " ";
                    prevSmall = arr[i - 1];
                }
                else
                {
                    result += prevSmall + " ";
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
