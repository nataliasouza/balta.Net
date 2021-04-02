using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("a040434d-5efe-4a74-8c03-89313d5a638f");

            if(id == Guid.NewGuid())
            Console.WriteLine(id.ToString().Substring(0,8));
        }
    }
}
