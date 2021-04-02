using System;

namespace InterpolacaoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var pricePromotion = 10.2;
            var price = 19.9;
            //var texto = "O preço do produto é " + price + " apenas na promoção";
            //var texto = string.Format("O preço do produto é {0} apenas na promoção! E o preço normal é {1}", pricePromotion, price);
            var texto = $@"O preço do produto em promoção é: {pricePromotion}!
            E seu preço normal é {price}";

            Console.WriteLine(texto);
        }
    }
}
