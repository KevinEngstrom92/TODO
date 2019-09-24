using System;


namespace TODO
{
    class Engine
    {
        static Task[] taskList = new Task[100];
        static int counter = 0;
        public static void ListTodo()
        {
            Console.Clear();
            Console.WriteLine("Name:\t\tDueDate:\t\tCompleted:");

            foreach (var task in taskList)
            {
                if (task == null) continue;
                Console.WriteLine($"{task.Name}\t\t{task.DueDate}\t{task.IsCompleted}");
            }
            Console.ReadKey(true);
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
