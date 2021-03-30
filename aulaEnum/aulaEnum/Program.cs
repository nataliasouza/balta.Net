using System;

namespace aulaEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product ( 1, "Mouse Gamer", 199.90, EProductType.Product);
            Product manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 550.00, EProductType.Service);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
        }
    }

    struct Product
    {
        public Product (int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PrinceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}
