using System;

namespace CW_Task1
{
    //    Создайте:
    //•	класс Human; 
    //•	делегат, который может быть проассоциирован с методом, который ничего не возвращает и не принимает.
    //В теле класса Human создайте:
    //•	событие JumpE, в соответствии с делегатом. 
    //•	защищенный механизм доступа к событию для добавления и удаления методов-обработчиков.
    //•	метод Jump, выводящий на экран слово «прыгаю».
    //Создайте экземпляр Human в методе Main, подпишите метод Jump на событие JumpE.
    //Вызовите возникновение события JumpE.

    public delegate void HumamDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            var hum = new Human();
            hum.JumpE += hum.Jump;
            hum.InvokeEvent();
            Console.ReadKey();
        }
    }
}
