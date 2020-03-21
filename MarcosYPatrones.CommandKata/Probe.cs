using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.CommandKata
{
    public class Probe : IUnit
    {
        public Queue<ICommand> Commands { get; set; }

        public int Minerals { get; set; }

        public Point Position { get; set; }

        public Probe()
        {
            this.Minerals = 0;
            this.Position = new Point();
            this.Commands = new Queue<ICommand>();
        }

        public void Move(int x, int y)
        {
            Commands.Enqueue(new MoveCommand(this,x,y));
        }

        public void Gather()
        {
            Commands.Enqueue(new GatherCommand(this));
        }
    }
}
