using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp
{
    public class Task
    {
        public string Description { get; set; }
        public string DueDate { get; set; }
        public bool IsCompleted { get; set; } = false;
    
        public Task(string description)
        {
        }

        public override string ToString()
        {
            return $"{DueDate} - {Description} - Completed: {IsCompleted}";
        }
    }
}
