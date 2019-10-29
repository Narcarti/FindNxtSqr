using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextSqr
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(FindNextSqrt(155));
            Console.WriteLine(FindNextSqrt(121));
            Console.WriteLine(FindNextSqrt(100));

            Console.ReadKey();
        }

        private static long FindNextSqrt(long sqrd)
        {
            var sqr = Math.Sqrt(sqrd);
            
            return (long)(sqr%1==0 ? ((sqr+1) *(sqr + 1)) : -1); 

           
        }
    }
}
