using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Group
    {
        public string Title { get; set; }
        public Group(string title)
        {
            Title = title;
            Students = new List<Student>();
        }

        public List<Student> Students { get; }

        public void AddStudent(Student student)
        {
            if (!Students.Contains(student)) Students.Add(student);
            else throw new ArgumentException("Студент уже зачислен в группу");
        }

        public bool ExpelStudent(int student_id)
        {
            foreach (Student student in Students) if (student.ID == student_id)
                {
                    Students.Remove(student);
                    return true;
                }
            return false;
        }

        public override string ToString()
        {
            int i = 1;
            string result = $"список студентов группы {Title}\n";
            foreach (Student student in Students)
            {
                result += $"{i}: {student}\n";
                i++;
            }

            return result;
        }
    }
}