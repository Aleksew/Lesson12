﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

//Напишите консольное приложение, которое будет отслеживать нажатие кнопок клавиатуры и полностью заполнять экран консоли значениями нажатого символа,
//при этом каждый раз после нажатия клавиши цвет текста (Console.ForegroundColor) должен меняться случайным образом (кроме черного).
//Детали:
//•	Создайте класс KeyEventArgs, наследник EventArgs.  В теле класса создайте автосвойство PressedKey типа char. 
//•	Создайте класс Keyboard. В теле класса создайте: 
//o событие типа EventHandler с именем PressedKeyEventHandler, закрытого KeyEventArgs. 
//o	Создайте метод PressKeyEvent, принимающий char, запускающий выполнение события и передающий далее значение полученного char (помещенного в KeyEventArgs).
//o Метод Start, обращающийся к консоли для считывания нажатой клавиши. Если нажата любая клавиша кроме q (в любом регистре и с учетом кириллицы), должно запускаться событие. 
//  Иначе в цикле продолжается запрос на ввод символа. Если введен q – выполняется очистка экрана консоли и выводится на экран красным цветом строка “You are exiting the program!”.
//•	В классе Program создайте метод PressedKeyHandler, который может быть подписан на событие PressedKeyEventHandler. Задача метода:
//o Установить максимально допустимый для системы размер окна консоли по ширине и высоте.
//o	Очистить экран консоли.
//o	Изменить цвет текста в консоли случайным образом, но так, чтобы он не повторялся с предыдущим цветом текста консоли. 
//o	Вывести на экран максимально возможное для данного экрана консоли количество символов, который был нажат пользователем на клавиатуре.
//В методе Main создайте экземпляр класса Keyboard, подпишите на его событие соответствующий метод и запустите метод Start.

namespace Task1
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);

        static void Main(string[] args)
        {
            Keyboard keyboard = new Keyboard();

            keyboard.PressedKeyEventHandler += new EventHandler<KeyEventArgs>(PressedKeyHandler);
            keyboard.Start();
        }

        public static void PressedKeyHandler(char simbol)
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3);

            Console.Clear();
            RandomColorConsole();

            for (int i = 0; i < Console.LargestWindowHeight; i++)
            {
                Console.Write(new string(simbol, Console.LargestWindowWidth));
            }
            Console.SetCursorPosition(0, 0);
        }

        public static void RandomColorConsole()
        {
            var colorRandom = (ConsoleColor)new Random().Next(1, 16);
            if (Console.ForegroundColor == colorRandom)
            {
                RandomColorConsole();
            }
            Console.ForegroundColor = colorRandom;
        }
    }
}
