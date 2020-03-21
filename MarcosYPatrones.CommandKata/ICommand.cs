using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.CommandKata
{
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
    }
}
