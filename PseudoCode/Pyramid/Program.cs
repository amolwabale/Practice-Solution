using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {

        static void PrintPyramid(int numOfRow)
        {
            for(var i = 1; i<= numOfRow; i ++)
            {
                for (var spaces = 1; spaces <= (numOfRow - i); spaces++)
                    Console.Write(" ");
                for (var Number = 1; Number <= i; Number++)
                    Console.Write("#");
                for(var Number = (i-1); Number >=1; Number--)
                    Console.Write("#");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            PrintPyramid(8);
            int numberoflayer = 6, Space, Number;
            Console.WriteLine("Print paramid");
           
        }
    }
}
