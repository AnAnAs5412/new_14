using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Alex", 20, 1234);
            Teacher teacher = new Teacher("Ann", 30, 3456, "Math");
            Subject subject = new Subject("Math", "Ann", 30, 3456, "Math");
            Course course = new Course("Alex", 20, 1234, 2);
            Count_subject count_Subject = new Count_subject("Alex", 20, 1234, 2, 3);
            Console.WriteLine("Какая информация требуется?");
            string a = Console.ReadLine();
            switch (a)
            {
                case "student":
                    Console.WriteLine(student);
                    student.Students();
                    break;
                case "teacher":
                    Console.WriteLine(teacher);
                    teacher.Teachers();
                    break;
                case "subject":
                    Console.WriteLine(subject);
                    subject.Teachers_Subject();
                    break;
                case "course":
                    Console.WriteLine(course);
                    course.Courses();
                    break;
                case "count_Subject":
                    Console.WriteLine(count_Subject);
                    count_Subject.Counts_subject();
                    break;
            }
        }
    }
    public class People
    {
        public string name { get; set; }
        public int age { get; set; }
        public People(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Hello()
        {
            Console.WriteLine($"Здравствуйте, {name}");
            return;
        }
    }
    class Student : People
    {
        public int id_student { get; set; }
        public Student(string name, int age, int id_student) : base(name, age)
        {
            this.id_student = id_student;
        }
        public void Students()
        {
            Console.WriteLine($"Ваш id {id_student}");
            return;
        }
    }
    class Teacher : People
    {
        public int id_teacher { get; set; }
        public string subject { get; set; }
        public Teacher(string name, int age, int id_teacher, string subject) : base(name, age)
        {
            this.id_teacher = id_teacher;
            this.subject = subject;
        }
        public void Teachers()
        {
            Console.WriteLine($"Ваш id {id_teacher}");
            Console.WriteLine($"Ваш предмет {subject}");
            return;
        }
    }
    class Subject : Teacher
    {
        public string Name_Subject { get; set; }
        public Subject(string Name_Subject, string name, int age, int id, string subject) : base(name, age, id, subject)
        {
            this.Name_Subject = Name_Subject;
        }
        public void Teachers_Subject()
        {
            Console.WriteLine($"{Name_Subject} ведет {name}, {age} лет, {id_teacher}");
            return;
        }
    }
    class Course : Student
    {
        public int course { get; set; }
        public Course(string name, int age, int id_student, int course) : base(name, age, id_student)
        {
            this.course = course;
        }
        public void Courses()
        {
            Console.WriteLine($"Студент {name}, {age}, {id_student} учится на {course} курсе");
            return;
        }
    }
    class Count_subject : Course
    {
        public int count_subject { get; set; }
        public Count_subject(string name, int age, int id_student, int course, int count_subject) : base(name, age, id_student, course)
        {
            this.count_subject = count_subject;
        }
        public void Counts_subject()
        {
            Console.WriteLine($"У cтудента {name}, {age}, {id_student}, {course} курса {count_subject} пар");
            return;
        }
    }
}
