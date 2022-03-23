using System;

namespace type_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("Implicit Conversion");
            byte a = 5; 
            sbyte b = 30;   // 1 byte
            short c = 10;   // 2 byte

            int d = a + b + c;  // 4 byte
            Console.WriteLine("d: " + d);

            long h = d; // 8 byte
            Console.WriteLine("h: " + h);

            float i = h;    // 4 byte
            Console.WriteLine("i: " + i);

            string e = "Beliz";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g: " + g);

            //Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("Explicit Conversion");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            float fl = 10.3f;
            byte z = (byte)fl;
            Console.WriteLine("z: " + z);

            // ToString Methodu
            Console.WriteLine("ToString Methodu");
            int int1 = 6;
            string str1 = int1.ToString();
            Console.WriteLine("str1: " + str1);

            string str2 = 12.5f.ToString();
            Console.WriteLine("str2: " + str2);

            //System.Convert
            Console.WriteLine("System.Covert");
            string s1 = "10";
            string s2 = "20";
            int num1, num2;
            int total;

            num1 = Convert.ToInt32(s1);
            num2 = Convert.ToInt32(s2);

            total = num1 + num2;
            Console.WriteLine("total: " + total);

            //Parse
            Console.WriteLine("Parse Method");
            ParseMethod();
        }
        public static void ParseMethod()
        {
            string str1 = "10";
            string str2 = "10.25";
            int i1;
            double d1;

            i1 = Int32.Parse(str1);
            d1 = Double.Parse(str2);

            Console.WriteLine("i1: " + i1);
            Console.WriteLine("d1: " + d1);
        }
    }
}
