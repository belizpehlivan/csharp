using System;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.WriteLine("Enter a num");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entered number:"  + num1);
            }
            catch(Exception ex){
                Console.WriteLine("Error: " + ex.Message.ToString());
            }
            // finally{
            //     Console.WriteLine("Completed");
            // }
            

            try{
                //int x = int.Parse(null);
                //int y = int.Parse("test");
                int z = int.Parse("-200000000000");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Null value entered");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("Completed");
            }
        }
    }
}
