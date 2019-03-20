using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter temperature in Celsius : ");
            double tempInC = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter temperature in Fahrenheit : ");
            double tempInF = Convert.ToDouble(Console.ReadLine());
            double intResultC = Converter.ToFahrenhiet(tempInC);
            double intResultF = Converter.ToCelsius(tempInF);
            Console.WriteLine("\n\nTemperature in Celsius is : {0} while Temperature in Fahrenheit is : {1}", intResultC, intResultF);
            Console.WriteLine("--------------------------------------------------------------");
            string a = Converter.count.ToString();
            Console.WriteLine("----------------------------cnt1 abt to create----------------------------------");
            Converter1 cnt = new Converter1();
            Console.WriteLine("--------------------------cnt2 abt to create------------------------------------");
            Converter1 cnt2 = new Converter1();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("\n\nTemperature in Celsius is : {0} while Temperature in Fahrenheit is : {1}" + a, Converter1.ToFahrenhiet(tempInC), Converter1.ToCelsius(tempInF));
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }

     public static class Converter {
        static int _count;
        static Converter() {
            Console.WriteLine("Constructor Static Converter called");
        }
        public static int count {
            get {
                return _count;
            }
            set
            {
                _count = value;
            }
        }
        public static double ToCelsius(double temp)
        {
            double convertedResult = (temp - 32) * (5.0 / 9.0);
            return convertedResult;
        }
        public static double ToFahrenhiet(double temp)
        {
            double convertedResult = (temp * 9.0 / 5.0) + 32;
            return convertedResult;
        }
    }


     public class Converter1
     {
         static int _count;
         static Converter1()
         {
             Console.WriteLine("Constructor Static Converter1 called");
         }

         public Converter1()
         {
             Console.WriteLine("Constructor Instance Converter1 called");
         }
         public static int count
         {
             get
             {
                 return _count;
             }
             set
             {
                 _count = value;
             }
         }
         public static double ToCelsius(double temp)
         {
             double convertedResult = (temp - 32) * (5.0 / 9.0);
             return convertedResult;
         }
         public static double ToFahrenhiet(double temp)
         {
             double convertedResult = (temp * 9.0 / 5.0) + 32;
             return convertedResult;
         }
     }
}
