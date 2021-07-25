using System;

namespace Task1
{
    public delegate void EventHandler<KeyEventArgs>(char simbol);

    public class Keyboard
    {
        public event EventHandler<KeyEventArgs> PressedKeyEventHandler;

        public void PressedKeyEvent(char simbol)
        {
            PressedKeyEventHandler(simbol);
        }

        public void Start()
        {
            while (true)
            {
                var input = Console.ReadKey();

                if (input.Key != ConsoleKey.Q)
                {
                    PressedKeyEvent(input.KeyChar);
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are exiting the program!");
                    Console.ReadKey();
                    break;
                };
            }
        }
    }
}
