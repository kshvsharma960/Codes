using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classClarification
{
    public class Person
    {
        private int _id= 1;
        public int id { 
            get{
                return _id;
            }
            set{
                _id = value;
            }
        }
        string _name = "Default";
        public string name {
            get {
                return _name;
            }
            set{
                _name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person p1 = new Person();
            p.id = 2;
            p.name = "Keshav";

            Console.WriteLine(p.id);
            Console.WriteLine(p.name);
            Console.WriteLine("----------------------");

            Console.WriteLine(p1.id);
            Console.WriteLine(p1.name);

            Console.ReadLine();

        }
    }
}
