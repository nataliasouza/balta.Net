using System;

namespace DateTime01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            //var formatada = String.Format("{0}", data);
            //var formatada = String.Format("{0:yyyy}", data);
            //var formatada = String.Format("{0:M}", data);
            //var formatada = String.Format("{0:dd/MM/yyyy}", data);
            var formatada = String.Format("{0:hh:mm:ss}", data);
            Console.WriteLine(formatada);
        }
    }
}
