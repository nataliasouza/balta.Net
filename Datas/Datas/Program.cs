using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = new DateTime(1984, 12, 01, 10, 37, 07);
            //var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.DayOfWeek);
        }
    }
}
