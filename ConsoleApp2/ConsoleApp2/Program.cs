using System;

namespace ConsoleApp2
{
    internal class Program
    {
        float num, precent;
        static void Main(string[] args)
        {
           Program program = new Program();
            program.Accept();
            program.Print();
            Console.ReadLine(); 

        }

        public void Accept()
        {
            Console.WriteLine("Sisesta hinne: ");
            num = float.Parse(Console.ReadLine());
        }

        public void Print()
        {
            precent = (float)num / 850 * 100;

            if (precent < 35)
            {
                Console.WriteLine("Sorry! You failed. Your mark is "+ precent);
            }
            else if (precent >35 && precent < 50)
            {
                Console.WriteLine("You got grade C anf your % mark is " + precent);
            }
            else if (precent > 50 && precent < 60)
            {
                Console.WriteLine("You got grade B anf your % mark is " + precent);
            }
            else if (precent >60 && precent < 75)
            {
                Console.WriteLine("You got grade A anf your % mark is " + precent);
            }
        }
    }
}
