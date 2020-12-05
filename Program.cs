using System;
using University.Data;
using University.Data.Models;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UniversityContext())
            {
                var student = new Student();
                student.Name = Console.ReadLine();
                student.PhoneNumber = Console.ReadLine();
                student.RegisteredOn = DateTime.Now;

                context.Students.Add(student);

                //context.Courses.Add(new Course
                //{
                    //Name = "Kotlin",
                    //Price = 0,
                    //Description = "Андроид курсы",
                    //StartDate = DateTime.Today,
                    //EndDate = DateTime.Today.AddDays(30)
                //});

                context.SaveChanges();
            }
        }
    }
}
