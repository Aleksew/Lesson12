using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Task1
{
    public class Human
    {
        HumamDelegate humanEvent = null;

        public virtual event HumamDelegate JumpE
        {
            add { humanEvent += value; }
            remove { humanEvent -= value; }
        }

        public void Jump()
        {
            Console.WriteLine("Прыгаю");
        }

        public void InvokeEvent()
        {
            humanEvent?.Invoke();
        }
    }
}
