using System;
using Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            double prec = 0;
            double number = 0;
            int n = 0;
            bool isInt;
            Console.WriteLine("Enter number:");
            isInt = double.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("Enter root:");
            isInt = Int32.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Enter precision:");
            isInt = double.TryParse(Console.ReadLine(), out prec);
            NutonClass.Root(number, n, prec);


        }
    }
}
