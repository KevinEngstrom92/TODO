using System;

namespace TODO
{
    class Task
    {
        

        public int InternalID { get; set; }
        public string Name { get; private set; }
        public DateTime? DueDate { get; private set; }
        public DateTime? Completed { get; set; }
        public bool IsCompleted
        {
            get
            {
                return Completed != null;
            }

        }


        public Task(string name, DateTime dueDate)
        {
            Name = name;
            DueDate = dueDate;
           InternalID = Engine.id++;
        }
    }
}
