using System;

namespace Task1
{
    public class KeyEventArgs : EventArgs
    {
        private char pressedKey { get; }

        public  KeyEventArgs(char simbol)
        {
            pressedKey = simbol;
            Console.WriteLine($"KeyEventArgs {simbol}");
        }
    }
}
