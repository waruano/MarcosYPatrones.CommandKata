using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.CommandKata
{
    public class GatherCommand : ICommand
    {
        private IUnit unit;

        public GatherCommand(IUnit unit)
        {
            this.unit = unit;
        }

        public bool CanExecute() {
            return unit.Minerals == 0;
        }

        public void Execute() {
            if (CanExecute()) {
                unit.Minerals += 5;
                Console.WriteLine($"Gather, Minerals: {unit.Minerals}");
            }
            else
            {
                Console.WriteLine($"Do not Gather, Minerals: {unit.Minerals}");
            }
        }
    }
}
