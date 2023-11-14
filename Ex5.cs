using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex5
    {
        static int Main(string[] args) {
            Random rd = new Random();
            Console.WriteLine("Enter array ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++) a[i] = rd.Next(1, 20);
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i] + " ");
            int max = a[0];
            
            for (int i = 1; i < n; i++)
                if (a[n] > max)
                    max = a[n];
            return max;
        }
    }
    
}
