using System;

namespace TODO
{
    class Task
    {
        public string Name { get; private set; }
        public DateTime DueDate { get; private set; }


        public Task(string name, DateTime dueDate)
        {
            Name = name;
            DueDate = dueDate;
        }
    }
}
