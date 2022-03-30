using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr1 = new int[10];
            // arr1[2] = 12;

            // string[] colors = {"red", "blue", "yellow", "pink"};

            // int[] arr2;
            // arr2 = new int[4];

            // int[] arr = new int[5];
            // int total = 0;
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.Write("Enter {0}. number:", i+1);
            //     arr[i] = Convert.ToInt32(Console.ReadLine());
            //     total += arr[i];
            // }
            // double avr = total / 5;
            // Console.WriteLine("Average: " + avr);

            int[] arr = {13, 11, 3, 15, 5, 7, 9 ,17};
            Console.WriteLine("Unsorted Array");
            foreach(var item in arr)
                Console.WriteLine(item);

            Console.WriteLine("Sorted Array");
            Array.Sort(arr);
            foreach(var item in arr)
                Console.WriteLine(item);
           
            Console.WriteLine("Clear");
            //void Array.Clear(Array array, int index, int length) 
            Array.Clear(arr, 2, 2);
            foreach(var item in arr)
                Console.WriteLine(item);

            Console.WriteLine("Reverse");
            Array.Reverse(arr);
            foreach(var item in arr)
                Console.WriteLine(item);

            Console.WriteLine("IndexOf");
            Console.WriteLine(Array.IndexOf(arr,17));

            Console.WriteLine("Resize");
            Array.Resize<int>(ref arr,9);
            arr[8] = 20;

            foreach(var item in arr)
                Console.WriteLine(item);

        }
    }
}
