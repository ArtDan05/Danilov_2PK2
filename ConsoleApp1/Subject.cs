using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Subject
    {
        public string Title { get; }
        public List<string> Tasks { get; set; }
        public int Hours { get; }
        public Subject(string title, int hours)
        {
            Title = title;
            Hours = hours;
            Tasks = new List<string>();
        }

        public void AddTask(string taskTitle)
        {
            if (!Tasks.Contains(taskTitle)) throw new ArgumentException("СУЩЕСТВУЕТ ААААААААААААААААААААААААААААААА");
            else Tasks.Add(taskTitle);
        }
    }
}