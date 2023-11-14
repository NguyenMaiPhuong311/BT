using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program44
    {
        static void Main(string[] args) {
            string source = "baitap";
            char value = 'a';
            int k=Dem(source, value);
            Console.WriteLine(k);

        }

        public static int Dem(string source,int value)
        {
            int count = 0;
            foreach (char c in source)
            {
                if (c == 'a')
                {
                    count++;

                }
            }
            return count;
        }
    }
}
