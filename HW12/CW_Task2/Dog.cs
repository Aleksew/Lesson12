using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Task2
{
    public delegate EventHandler<OrderEventArgs> OrderToDog();
    public class Dog
    {
        public string Order { get; set; }

        public void OrderHandler(object sender, OrderEventArgs e)
        {
            Console.WriteLine(e.GetType().Name );

            if ( true)//e.GetType
            {
                Console.WriteLine($"Я выполняю команду {e.Order}");
                Order = e.Order;
            }
            else
            {
                Console.WriteLine("Подозрительно смотрю на постороннего");
            }
        }
    }
}