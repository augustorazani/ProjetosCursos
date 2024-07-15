using PedidoEnum.Entities;
using PedidoEnum.Entities.Enums;
using System;

namespace PedidoEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Order order = new Order
                {
                    Id = 1000,
                    Moment = DateTime.Now,
                    Status = OrderStatus.PendingPayment
                };
                Console.WriteLine(order);  //utiliza override para retornar dados

                string txt = OrderStatus.PendingPayment.ToString(); //converte valor ENUM para String (atribuir o status PendingPaymente a var txt) 
                OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), value: "Delivered", true);
                //Enum.TryParse("Delivered", true, out os); <- forma alternativa funcional
                //OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); <- dessa forma nao funcionou
                Console.WriteLine(txt);
                Console.WriteLine(os);

                Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}