using PraticaPOO_Balta.ContentContext;
using System;

namespace PraticaPOO_Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var course = new Course();
            course.Level = ContentContext.Enums.EContentLevel.Beginner;
            foreach (var item in course.Modules)
            {

            }

            var carrer = new Carrer();
            carrer.Items.Add(new CarrerItem());
            Console.WriteLine(carrer.TotalCourses);
        }
    }
}
