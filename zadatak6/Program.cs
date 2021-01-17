using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak6
{
    class Program
    {
        static void Main(string[] args)
        {
            long n,x=0;
            


            Console.WriteLine("upisite broj do kuda ce se zbrajati: ");
            n=Convert.ToInt64(Console.ReadLine());
            for(long i = 0; i <= n; i++)
            {
                
                x=x+i;
                
            }
            Console.Write("Zbroj prvih ");
            Console.Write(n);
            Console.Write(" brojeva je ");
            Console.Write(x);
            Console.ReadKey();

        }
    }
}
