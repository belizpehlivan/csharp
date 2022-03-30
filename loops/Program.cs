using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // for(int i = 1; i < 10; i++){
            //     if(i==4)
            //         break;
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("****");
            // for(int i = 1; i < 10; i++){
            //     if(i==4)
            //         continue;
            //     Console.WriteLine(i);
            // }


            // int odd = 0;
            // int even = 0;
            // for(int i=1; i < 100; i++)
            // {
            //     if(i%2==0)
            //         even += i;
            //     else 
            //         odd += i;
            // }
            // Console.WriteLine("Total num of odd numbers: " + odd + "\nTotal num of even numbers: " + even);
        
            // average from 1 to num
            // Console.WriteLine("Enter a number: ");
            // int num = int.Parse(Console.ReadLine());
            // int count = 1;
            // int total = 0;

            // while(count<num){
            //     total+=count;
            //     count++;
            // }
            // Console.WriteLine(total/num);

            // char ch = 'a';
            // while(ch <= 'z'){
            //     Console.Write(ch);
            //     ch ++;
            // }

            string[] cars = {"Nissan", "Ford", "Toyota", "BMW"};
            foreach(var item in  cars){
                Console.WriteLine(item);
            }
        
        }
    }
}
