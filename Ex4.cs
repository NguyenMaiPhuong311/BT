using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex4
    {
        static void Main(string[] args) {
            Random rd = new Random();
            Console.WriteLine("Enter array ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++) a[i] = rd.Next(1, 20);
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i] + " ");
            Console.WriteLine("Enter position: ");
            int index= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x: ");
           int x= int.Parse(Console.ReadLine());
            if(index<=1|| index >= a.Length - 1)
            {
                Console.WriteLine("Can not insert");
            }
            else 
            {
                
                  for (int i = n - 1; i >= index - 1; i--)
                    a[i + 1] = a[i];
                a[index-1] = x;
                for (int i = 0; i < a.Length; i++)
                    Console.WriteLine(a[i] + " ");

            }
        }
    }
}
