using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {

            // bool condition = true;

            // if (condition)
            // {
            //     Console.WriteLine("Değişken: true");
            // }
            // else
            // {
            //     Console.WriteLine("Değişken: false");
            // }
            int time = DateTime.Now.Hour;
            string message = time>=6 && time <11 ? "Good Morning!" : time<=18 ? "Good Afternoon!" : "Good evening!";
            Console.WriteLine(message);
        }
    }
}
