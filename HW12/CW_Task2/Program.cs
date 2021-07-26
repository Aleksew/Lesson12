using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Task2
{
//Создайте класс OrderEventArgs, унаследуйте его от класса EventArgs(базового класса для определения классов-аргументов событий). В теле класса создайте строковое автосвойство Order.
//Создайте 2 класса – Owner и NotOwner.
//В теле каждого из этих классов создайте:
//•	Событие типа EventHandler, закрытого OrderEventArgs и с именем OrderToDog.
//•	Создайте метод GiveAnOrder, который принимает строку, создаёт экземпляр OrderEventArgs, помещает в него строку-аргумент метода и вызывает метод Invoke на событии. 
//Создайте класс Dog.В теле класса создайте: 
//•	Строковое автосвойство Order;
//•	Метод OrderHandler – метод обработчик события, принимающий два параметра – типа object (с именем sender) и типа OrderEventArgs(с именем e). Если источник события – экземпляр класса Owner:
//1.	Выведите на экран строковое значение команды, полученное из OrderEventArgs("Я выполняю команду {e.Order}").
//2.	Присвойте свойству Order строковое значение команды.
//•	Если источник события не Owner – выведите на экран строку «Подозрительно смотрю на постороннего».
//В теле метода Main создайте экземпляр класса Dog. Создайте экземпляры классов Owner и NotOwner и подпишите на события этих классов метод OrderHandler.
//Вызовите события экземпляров Owner и NotOwner.
//Выведите на экран значение свойства Order экземпляра Dog.

    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            var owner = new Owner();
            var notOwner = new NotOwner();

            //owner.OrderToDog += new Dog. ;

        }
    }
}
