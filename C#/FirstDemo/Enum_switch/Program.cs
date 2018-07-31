using System;
using System.Collections;
using System.Collections.Generic;

namespace Enum_switch
{
    class MainClass
    {
        private static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>(){
                new Todo { Description = "Task 1", EsimatedHours = 6, Status= Status.Completed},
                new Todo { Description = "Task 2", EsimatedHours = 2, Status= Status.InProgress},
                new Todo { Description = "Task 3", EsimatedHours = 8, Status= Status.NotStarted},
                new Todo { Description = "Task 4", EsimatedHours = 12, Status= Status.Deleted},
                new Todo { Description = "Task 5", EsimatedHours = 6, Status= Status.NotStarted},
                new Todo { Description = "Task 6", EsimatedHours = 2, Status= Status.InProgress},
                new Todo { Description = "Task 7", EsimatedHours = 14, Status= Status.Completed},
                new Todo { Description = "Task 8", EsimatedHours = 8, Status= Status.InProgress},
                new Todo { Description = "Task 9", EsimatedHours = 8, Status= Status.Completed},
                new Todo { Description = "Task 10", EsimatedHours = 8, Status= Status.NotStarted},
                new Todo { Description = "Task 11", EsimatedHours = 4, Status= Status.Completed},
                new Todo { Description = "Task 12", EsimatedHours = 10, Status= Status.NotStarted},
                new Todo { Description = "Task 13", EsimatedHours = 12, Status= Status.Completed},
                new Todo { Description = "Task 14", EsimatedHours = 6, Status= Status.Completed},
            };

            PrintAssessment(todos);
            Console.ReadLine();

        }
        private static void PrintAssessment(List<Todo> todos)
        {

            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Description);
            }
        }

        class Todo
        {
            public string Description { get; set; }
            public int EsimatedHours { get; set; }
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
}