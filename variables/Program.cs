using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
             Variable names are case sensitive
             Datetime    https://docs.microsoft.com/tr-tr/dotnet/api/system.datetime?view=netcore-3.1
             String kütüphanesi  https://docs.microsoft.com/tr-tr/dotnet/api/system.string?view=netcore-3.1
            */

            short s = 5;            //2 byte
            ushort us = 5;          //2 byte

            int intvar = 2;           //4 byte
            Int16 int16 = 2;          //2 byte
            Int32 int32 = 2;          //4 byte
            Int64 int64 = 2;          //8 byte
            
            uint ui = 2;            //4 byte
            long l = 4;             //8 byte
            ulong ul = 4;           //8 byte
            float f = 5;            //4 byte
            double d = 5;           //8 byte
            decimal de = 5;         //16 byte

            object obj1 = "o"; //str
            object obj2 = 'o'; //char
            object obj3 = 2;
            object obj4 = 2.1;

            string str_ = string.Empty;
            string name = "Beliz";
            string surname = "Pehlivan";
            string full_name = name + " " + surname;


            // bool
            bool bool1 = 5>3;
            Console.WriteLine(bool1); // true

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt); // 3/22/2022 2:04:48 PM

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string datetime3 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(datetime3);

            string str1 = "20";
            int int20 = 20;
            string str2 = str1 + int20.ToString(); // 2020
            Console.WriteLine(str2);

            int int2 = int20 + Convert.ToInt32(str1); // 40
            Console.WriteLine(int2);

            int int3 = int20 + int.Parse(str1); // 20+20=40
            Console.WriteLine(int3);

            /*
            !!!variable names same but variable type is different ERROR!!
            int varr = 5;
            string varr = "hello";
            Console.WriteLine(varr);
            */

        }
    }
}
