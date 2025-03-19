using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System.Collections.Concurrent;

namespace Enumeracoes

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendigPayments
            };

            Console.WriteLine(order);

            //Conversão de tipo Enum para String

            string txt = OrderStatus.PendigPayments.ToString();

            //Conversão de tipo String para Enum

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt); 
        }
    }
}
