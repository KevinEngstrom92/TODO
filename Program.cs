using System;


namespace TODO
{
    class Engine
    {
        public static int id = 1;
        static Task[] taskList = new Task[100];
        static int counter = 0;
        public static void ListTodo()
        {
            bool shouldRun = true;

            while (shouldRun)
            { 
            Console.Clear();
            Console.WriteLine("ID:\tName:\t\tDueDate:\t\tCompleted:");

            foreach (var task in taskList)
            {
                if (task == null) continue;
                Console.WriteLine($"{task.InternalID}\t{task.Name}\t\t{task.DueDate}\t{task.IsCompleted}");
            }
            Console.WriteLine();
            Console.WriteLine("(M)ark as finished, (E)dit, e(X)it");

            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.M:
                    Console.Clear();
                    Console.Write("> ");
                    int IdToMarkClear = int.Parse(Console.ReadLine());

                    taskList[IdToMarkClear-1].Completed = DateTime.Now;


                    break;
                case ConsoleKey.E:

                    break;

                case ConsoleKey.X:
                        shouldRun = false;
                    break;
                }
            }
        }
        public static void AddTodo()
        {
            Console.Clear();
            Console.WriteLine("Title: ");
            string input = Console.ReadLine();
            Console.WriteLine("Due Date: ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());
            
            taskList[counter++] = new Task(input, dueDate);


            
        }
    }
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
                        Engine.AddTodo();       
                        break;
                    case ConsoleKey.D2:
                        Engine.ListTodo();
                        break;
                    case ConsoleKey.D3:
                        willExit = true;
                        break;
                }
            }
        }
    }
}
