using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal delegate bool printDataDelegate(delegateDemo employee);
    #region Program
    class Program:delegateDemo
    {
        static void Main(string[] args)
        {
            delegateDemo emp = new delegateDemo();
            emp.id = 100;
            emp.name = "Keshav";
            delegateDemo emp1 = new delegateDemo();
            delegateDemo emp2 = new delegateDemo();
            emp1.id = 101;
            emp1.name = "Vaibhav";
            
            emp2.id = 102;
            emp2.name = "Rahul";

            printDataDelegate del = new printDataDelegate(printData1);

            emp.PromotionAI(del);
            Console.WriteLine("-----------------------------");
            emp1.PromotionAI(del);
            Console.WriteLine("-----------------------------");
            emp2.PromotionAI(del);
            Console.ReadLine();

        }
       
    }
    #endregion
    #region DelegateClass
    class delegateDemo {
        int ID;
        string Name;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int id
        {
            get
            {
                return this.ID;
            }
            set
            {
                ID = value;
            }
        }


        public static bool printData1(delegateDemo e)
        {
            Console.WriteLine("PrintData1 output : ");
            if (e.id < 102)
            {
                return true;
            }
            return false;
        }
        public static bool printData2(delegateDemo e)
        {
            Console.WriteLine("PrintData2 output : ");
            return true;
        }
        public void PromotionAI(printDataDelegate del) {
            if (del(this)) {
                Console.WriteLine("Employee {0} is Promoted.",this.name);
            }
            else
            {
                Console.WriteLine("Employee {0} is Not Promoted.", this.name);
            }
        }
    }
        #endregion  
}
