using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viris_Sim_GageMcKenzie
{
    internal class Program
    {
        static List<(int, int)> StartPosition = new List<(int, int)> { (3, 3), (3, 4) };
        static Random movement = new Random();
        
        static void Main(string[] args)
        {
            Console.WriteLine($"-----");
            Console.WriteLine($"---^-");
            Console.WriteLine($"-----");
            Console.WriteLine($"~--^-");
            Console.WriteLine($"~~~~~");


            // char myChar = '8';

            Console.SetCursorPosition(StartPosition[0].Item1, StartPosition[0].Item2);
            Console.ReadKey();
            while (true)
            {
                virismovement();
                Console.ReadKey();
            }
            
            




        }

        static void virismovement()
        {
            int Vmovement = movement.Next(1, 2);
            
            
            
            if (Vmovement == 1)
            {
                
                int XMovement = StartPosition[0].Item1 -1;
                (int,int) newPosition = (XMovement, StartPosition[0].Item2);
                StartPosition[0] = newPosition;
                Console.SetCursorPosition(XMovement, StartPosition[0].Item2);
            }
            if (Vmovement == 2)
            {
                int XMovement = StartPosition[0].Item1 + 1;
                (int, int) newPosition = (XMovement, StartPosition[0].Item2);
                StartPosition[0] = newPosition;
                Console.SetCursorPosition(XMovement, StartPosition[0].Item2);
            }
            if (Vmovement == 3)
            {
                int YMovement = StartPosition[0].Item2 - 1;
                (int, int) newPosition = (StartPosition[0].Item1, YMovement);
                StartPosition[0] = newPosition;
                Console.SetCursorPosition(StartPosition[0].Item1, YMovement);
            }
            if (Vmovement == 4)
            {
                int YMovement = StartPosition[0].Item2 + 1;
                (int, int) newPosition = (StartPosition[0].Item1, YMovement);
                StartPosition[0] = newPosition;
                Console.SetCursorPosition(StartPosition[0].Item1, YMovement);
            }
        }
    }
}
