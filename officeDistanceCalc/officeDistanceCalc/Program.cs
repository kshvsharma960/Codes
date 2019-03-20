using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace officeDistanceCalc
{
    class Program:Iface
    {
        public void getData() { }

        static void Main(string[] args)
        {
            int Offices = 2;    //n
            int width = 3;      //x
            int height = 3;     //y
            int distance = distanceCalc(Offices, width, height);
            Console.WriteLine("\n\n-----------------------------------------------------------------");
            Console.WriteLine("Min distance will be : {0}", distance);
            Console.ReadKey();
        }
        public static int distanceCalc(int n,int x,int y) {
            int distance=0;
            int[,] matrixData = new int[x, y];
            int[,] matrixweight = new int[x, y];
            string[,] matrix = new string[x, y];
            for (int i = 0; i < x; i++) {
                for (int j = 0; j < y; j++) {
                    matrix[i, j] = i.ToString() + j.ToString();
                    matrixData[i, j] = Convert.ToInt32(matrix[i, j].ToCharArray()[0].ToString()) + Convert.ToInt32(matrix[i, j].ToCharArray()[1].ToString());
                    distance = (distance < matrixData[i, j]) ? matrixData[i, j] : distance;
                }
            }
            
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write( matrixData[i, j].ToString()+" ");
                }
            }


                return distance;
        }


}
    interface Iface
    {
        void getData();

    }
}
