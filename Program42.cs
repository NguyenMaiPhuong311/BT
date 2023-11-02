using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program42
    {

        static void Main(string[] args)
        {
            Random rd = new Random();
            Console.WriteLine("Enter array ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter value: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++) array[i] = rd.Next(1, 20);
            Console.WriteLine();

            xuatmang(array);

            int k = index(array, value);
            Console.WriteLine("The index of " + value + " in array is " + k);


        }

        private static void xuatmang(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + ", ");
            Console.WriteLine();
        }

        public static int index (int[] array, int value)
        {
            int index_dex = Array.IndexOf(array, value);
            for (int i = index_dex; i<array.Length-1; i++)
                array[i]= array[i + 1] ;
            for (int i = 0; i < array.Length-1; i++)
                Console.Write(array[i] + ",");
            return index_dex;

        }

       

        
    }
}
