using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Student : User
    {
        static int idCount = 0;
        public Dictionary<Subject, Dictionary<string, int>> Marks { get; }
        public Student(string login, string password)
        {
            Marks = new Dictionary<Subject, Dictionary<string, int>>();
            Login = login;
            Password = password;
            ID = idCount++;
        }

        public void AddMark(Subject subject, string task, int mark)
        {
            if (Marks.ContainsKey(subject)) { if (!Marks[subject].ContainsKey(task)) Marks[subject][task] = mark; }
            else Marks[subject].Add(task, mark);
        }

        public double GetTotalMarks()
        {
            throw new System.NotImplementedException();
        }

        public string ToString()
        {
            return $"{Login}";
        }
    }
}