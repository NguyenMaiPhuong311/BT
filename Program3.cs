

namespace ConsoleApp1
{
    internal class Program3
    {
        static void Main(string[] arrgs)
        {
            int choice;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Draw the  rectangle");
            Console.WriteLine("2. Draw the square triangle");
            Console.WriteLine("3. Draw the isosceles trianglee");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. Draw the  rectangle");
                    for(int i = 1; i <= 3; i++)
                    {
                        Console.WriteLine("* * * * * * *");
                    }
                    break;
                case 2:
                    Console.WriteLine("2. Draw the square triangle");
                    Console.WriteLine("top-left");
                    for (int i = 5; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    } // End First Pattern


                    Console.WriteLine("top-right");
                    for (int i = 5; i >=1; i--)
                    {
                        for (int k = 1; k <= 5 - i; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        
                        Console.WriteLine();
                    } // End Second Pattern

                    Console.WriteLine("botton-left");
                        for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    } // End Third Pattern

                    Console.WriteLine("botton-right");
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int k = 1; k <= 5 - i; k++)
                        {
                            Console.Write(" ");
                        }
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            
                        
                                Console.WriteLine();
                        } // End Fourth Pattern

                        break;
                case 3:
                    Console.WriteLine("3. Draw the isosceles trianglee");
                    for (int i = 7; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                        break;

            }
        }
    }
}
