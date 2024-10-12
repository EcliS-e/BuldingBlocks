using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string square = "Square";
            string circle = "circle";

            Console.WriteLine(circle, square);
            PrintNick();

            Console.WriteLine(TwoNums(3, 4));




            void PrintNick()
            {
                Console.WriteLine("Nick Buonorata");

            }

            int TwoNums(int num1, int num2)
            {
                int Result = num1 + num2;


                return Result;
            }
        }
    }
}
      
