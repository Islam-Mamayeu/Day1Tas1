using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
   public class NutonClass
    {
       public static void Root(double number, int n, double prec)
        {

            double A1 = number/2;
            double result =0;
            double precResult=1;
            while (Math.Abs(precResult) > prec)
            {
                result = ((n-1)*A1 + (number / Math.Pow(A1,n-1)))/n;
                precResult = A1-result;
                A1 = result;


            }
            Console.WriteLine(result);
            Console.WriteLine( Math.Pow(number, 1.0/n));
            Console.ReadKey();

        }
    }
}
