using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            arr1[2] = 12;

            string[] colors = {"red", "blue", "yellow", "pink"};
            
            int[] arr2;
            arr2 = new int[4];

            int[] arr = new int[5];
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0}. number:", i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                total += arr[i];
            }
            double avr = total / 5;
            Console.WriteLine("Average: " + avr);

        }
    }
}
