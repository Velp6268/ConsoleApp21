using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp12
{
    internal class Program
    {


        static void Main(string[] args)
        {

                Console.Write("Введите кол-во элементов массива: ");

                int n = int.Parse(Console.ReadLine());

                int[] Arr = new int[n];

                for (int i = 0; i < Arr.Length; i++)
                {
                    Console.Write($"\nВведите элемент массива под индексом {i}: ");
                    Arr[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"\nВывод массива:  ");

                for (int i = 0; i < Arr.Length; i++)
                {
                Console.Write(Arr[i] + " ");
                }

               
            
        

        int a, b;
            Console.Write("\n\nВведите целое число a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите целое число b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nЭлементы из интервала [{a}, {b}]: \n");

            int count = Task3.Pick(Arr, a, b);




            Task3.Check(count);


            Console.ReadLine();
        }
    }
}