using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group gr1 = new("2ПК2");
            Student stud1 = new Student("root1", "admin");
            Student stud2 = new Student("Nikonov Roman Dmitrievich", "ghhhufewe");

            gr1.AddStudent(stud1);
            gr1.AddStudent(stud2);

            Subject biology = new Subject("Биология", 52);
            Subject math = new Subject("Математика", 100);
            Subject rulang = new Subject("Русский язык", 100);

            biology.AddTask("Тема");
            math.AddTask("Тема");
            rulang.AddTask("Тема");

            Random r = new();

            foreach (Student student in gr1.Students)
            {
                student.AddMark(biology, "Тема", r.Next(0, 6));
                student.AddMark(math, "Тема", r.Next(0, 6));
                student.AddMark(rulang, "Тема", r.Next(0, 6));
            }
        }
    }
}
