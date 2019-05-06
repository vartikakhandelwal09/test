using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you hungry");
            char var = Convert.ToChar(Console.ReadLine());
            if(var == 'Y')
            {
                Console.WriteLine("Eat pizza");
            }
            else
            {
                Console.WriteLine("Do assignment");
            }
            
        }
    }
}
