using System;

namespace Task1
{
    public delegate void EventHandler<KeyEventArgs>(char simbol);
    public class Keyboard
    {
        public event EventHandler<KeyEventArgs> PressedKeyEventHandler = null;

        public void PressedKeyEvent(char simbol)
        {
            if (PressedKeyEventHandler != null)
            {
                PressedKeyEventHandler.Invoke(simbol);
            }
        }
    }
}
