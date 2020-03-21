using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.CommandKata
{
    public class MoveCommand : ICommand
    {
        private IUnit unit;
        private int x;
        private int y;

        public MoveCommand(IUnit unit, int x, int y)
        {
            this.unit = unit;
            this.x = x;
            this.y = y;
        }

        public bool CanExecute() {
            return true;
        }

        public void Execute() {
            this.unit.Position.X = this.x;
            this.unit.Position.Y = this.y;
            Console.WriteLine($"Move to {this.unit.Position.X} , {this.unit.Position.Y}");
        }
    }
}
