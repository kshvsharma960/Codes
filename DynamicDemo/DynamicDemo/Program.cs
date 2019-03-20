using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            dynamic d;
            var v = 0;
            dynamic dd = new Object();
            dd.id = 1;
            dd.name = "Keshav";
            for (d = 0; d < i; d++)
            {
                Console.WriteLine("Using DYNAMIC : "+d);        //Dynamiccally bounded    
            }
            for (v = 0; v < i; v++)
            {
                Console.WriteLine("Using VAR : " + v);          //Statically bounded
            }

            Console.WriteLine(dd.id + " : " + dd.name);
            Console.ReadLine();
        }
    }
}
