using Course.Entities;
using Course.Entities.Enums;
using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Para converter um valor de enumeração pra string basta usar o ToString();
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Como converter um valor em formato de string para enum?
            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); ERRO

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            Console.WriteLine(os);
            Console.ReadLine();
        }
    }
}
