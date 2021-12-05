using PraticaPOO_Balta.ContentContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PraticaPOO_Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre POO","orientacao-objeto"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();

            var coursePoo = new Course("Fundamentos POO", "fundamentos-poo");
            var courseCSharp = new Course("Fundamentos C#", "fundamentos-c#");
            var courseAspNet = new Course("Fundamentos ASP.NET","fundamentos-aspnet");

            courses.Add(coursePoo);
            courses.Add(courseCSharp);
            courses.Add(courseAspNet);
            

            var careerlist = new List<Career>();

            var careerNet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Introdução ao C#", "Iniciando com C#", courseCSharp);
            var careerItem2 = new CareerItem(2, "Introdução a POO", "Aprenda POO", coursePoo);
            var careerItem3 = new CareerItem(3, "Introdução ao ASP.NET ", "Aprenda .NET", courseAspNet);

            careerNet.Items.Add(careerItem);
            careerNet.Items.Add(careerItem3);
            careerNet.Items.Add(careerItem2);
            
            careerlist.Add(careerNet);

            foreach(var career in careerlist)
            {
                Console.WriteLine(career.Title);
                foreach(var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);    
                    
                    foreach(var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }                   
                }
            }

        }
    }
}
