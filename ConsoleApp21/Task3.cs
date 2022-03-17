using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Task3
    {
        public static void Task3All(int[] Arr, int a, int b, int count)
        {
            PrintMass(Arr);
            Pick(Arr, a, b);
            Check(count);
        }

       

            public static void PrintMass(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
                Console.Write(Arr[i] + " ");
        }


        public static int Pick(int[] Arr, int a, int b)
        {


            int count = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                if ((Arr[i] >= a) && (Arr[i] <= b))
                {
                    Console.Write(Arr[i] + " ");
                    count++;
                }
            }
            return count;
        }

       public static void Check(int count)
        {

            
            if (count != 0)
                Console.WriteLine($"\nКол-во элементов: {count} ");
            else
                Console.WriteLine("Элементов, которые входят в интервал a, b нет!");
            
        }
    }
}