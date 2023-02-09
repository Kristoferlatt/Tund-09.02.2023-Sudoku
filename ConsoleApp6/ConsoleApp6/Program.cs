using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Näita maksimaalset numbrit");

            int a = 700;
            int b = 400;
            int ret;

            Program program = new Program();
            ret = program.DisplayMax(a, b);
            Console.WriteLine("Maksimaalne väärtus on: {0}", ret );
            Console.ReadLine();
        }

        public int DisplayMax(int num1, int num2)
        {
            int reasult;
            
            if(num1 > num2)
            {
                reasult = num1;
            }
            else
            {
                reasult = num2;
                
            }
            return reasult; 
        }
    }
}
