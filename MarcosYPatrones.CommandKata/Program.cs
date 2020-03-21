using System;

namespace MarcosYPatrones.CommandKata
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            Probe probe = new Probe();
            do
            {
                Console.WriteLine();
                Console.WriteLine("Press 1 to enqueue move, 2 to enqueue gather or 3 to execute all commands");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine();
                        Console.WriteLine("Enter position x:");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter position y:");
                        int y = int.Parse(Console.ReadLine());
                        probe.Move(x,y);
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        probe.Gather();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        while(probe.Commands.Count > 0)
                        {
                            ICommand command = probe.Commands.Dequeue();
                            command.Execute();
                        }
                        break;
                    default:
                        continueProgram = false;
                        break;
                }

            } while (continueProgram);
        }
    }
}
