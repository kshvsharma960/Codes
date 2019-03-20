using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton a = Singleton.GetInstance;
            Singleton b = Singleton.GetInstance;
            Console.WriteLine("---------------------------------------");
            a.printMethod();
            Console.WriteLine("---------------------------------------");
            
            Console.WriteLine("\n\nConstructor for A Called {0} + {1} times----", a.count,b.count);
            b.printMethod();
            Console.WriteLine("---------------------------------------");
//            Console.WriteLine("Constructor Called {0} times", Singleton.count);
            Console.WriteLine("Constructor for A Called {0} times", a.count);
            Console.WriteLine("Constructor for B Called {0} times", b.count);
            Console.ReadLine();
        }
    }

    public sealed class Singleton
    {
        public int count = 0;
        public static object obj = new object();
        private static Singleton instance = null;
        private Singleton()
        {
            count += 1 ;
            Console.WriteLine("\n\nConstructor Called {0} times", count);
        }
        public static Singleton GetInstance {
            get
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void printMethod() {
            Console.WriteLine("PrintMethod is called...");
        }

        
    }
}
