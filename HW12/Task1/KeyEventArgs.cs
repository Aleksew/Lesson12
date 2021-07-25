using System;

namespace Task1
{
    public class KeyEventArgs : EventArgs
    {
        public KeyEventArgs(char pressedKey)
        {
            PressedKey = pressedKey;
        }
        public char PressedKey { get; private set; }
    }
}

