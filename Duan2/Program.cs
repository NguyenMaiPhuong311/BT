namespace Duan2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 Player with player");
            Console.WriteLine("2 Player with computer ");
            Console.WriteLine("3 Computer with computer ");

            Console.WriteLine("Choose number : ");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                TicTacToe game = new TicTacToe();
                game.play();
            }
            else if (num == 2)
            {
                TicTacToe game = new TicTacToe();
                game.play2();
            }
            else if (num == 3)
            {
                TicTacToe game = new TicTacToe();
                game.play3();
            }
            else
            {
                Console.WriteLine("Only 1,2,3");
            }

            Console.ReadKey();

        }
    }
}
