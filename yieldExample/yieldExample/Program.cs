using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yieldExample
{
    class Program
    {
        static int[] items;
        static void Main()
        {
            items = new int[5] { 5, 4, 7, 9, 3 };
            // Compute two with the exponent of 30.
            var computer = ComputePower(2, 20);
            //
            for (int i = 0; i < computer.Count();i++ )//foreach (int value in computer)
            {
                Console.Write(computer.ElementAt(i));
                Console.Write(" ");
            }
            Console.WriteLine("---------------------------------------------------------");
            for (int i = 0; i < computer.Count(); i++)//foreach (int value in computer)
            {
                Console.Write(computer.ElementAt(i));
                Console.Write(" ");
            }
            Console.WriteLine("---------------------------------------------------------");
            IEnumerable<int> data=BuildMyCollection();
            for (int i = 0; i < data.Count(); i++)//foreach (int value in computer)
            {
                Console.Write(data.ElementAt(i));
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public static IEnumerable<int> ComputePower(int number, int exponent)
        {
            int exponentNum = 0;
            int numberResult = 1;
            //
            // Continue loop until the exponent count is reached.
            //
            while (exponentNum < exponent)
            {
                //
                // Multiply the result.
                //
                numberResult *= number;
                if (exponentNum == 10)
                {
                     yield break;
                }
                exponentNum++;
                //

                // Return the result with yield.
                //
                yield return numberResult;
            }
        }

        public static  IEnumerable<int> BuildMyCollection()
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (i >= 2)
                {
                    yield break;
                    //break;
                }
                yield return items[i];
            }

            Console.WriteLine("You used break.");

            yield return 10;
        }

    }
}
