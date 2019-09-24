using System;

namespace TODO
{
    class Program
    {
        static void Main(string[] args)
        {

            bool willExit = false;

            while (!willExit)
            {
                Console.Clear();
                Console.WriteLine("1. Add ToDo");
                Console.WriteLine("2. List ToDo");
                Console.WriteLine("3. Exit");

                ConsoleKeyInfo input = Console.ReadKey(true);

                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        willExit = true;
                        break;
                }
            }
        }
    }
}
