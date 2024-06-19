using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Security.AccessControl;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
           {
               new Todo { Description = "Task 1", EstimatedHours = 6, Status = Status.Completed},
               new Todo { Description = "Task 2", EstimatedHours = 2, Status = Status.InProgress},
               new Todo { Description = "Task 3", EstimatedHours = 8, Status = Status.NotStarted},
               new Todo { Description = "Task 4", EstimatedHours = 12, Status = Status.Deleted},
               new Todo { Description = "Task 1", EstimatedHours = 4, Status = Status.OnHold},
           };

            Console.ForegroundColor = ConsoleColor.DarkRed;

            PrintAssessment(todos);
            Console.ReadLine();

        }

        private static void PrintAssessment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Description);

            }
        }


    }

    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }

    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }


}
