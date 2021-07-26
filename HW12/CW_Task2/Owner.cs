using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Task2
{
    class Owner
    {
        public event EventHandler<OrderEventArgs> OrderToDog = null;

        public void GiveAnOrder(string str)
        {
            var temp = new OrderEventArgs();
            temp.Order = str;
        }
        public void InvokeEvent(object sender, OrderEventArgs e)
        {
            OrderToDog.Invoke(sender, e);
        }
    }
}
