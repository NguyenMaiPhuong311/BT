using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex11231
    {
        static void Main(string[] args)
        {
            List<char> characters = new List<char>();
            characters.InsertRange(0, new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
            int value = characters[6];
            try
            {
                List characters = new List();
                characters.InsertRange(0, new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                int value = characters[6];
            }
            catch (IndexOutOfRangeException ex)
            {
                System.Console.WriteLine(ex);
            }

        }
    }
}
