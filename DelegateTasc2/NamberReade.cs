using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTasc2
{
    class NamberReade
    {
        public delegate void NumberReadeDelegate(/*int namber*/);
        public event NumberReadeDelegate NumberReadeEvent;
        public void StartProcess
        public virtual void ReadNamber(/*int namber*/)
        {
            NumberReadeEvent?.Invoke(/*namber*/);
        }

    }
}
