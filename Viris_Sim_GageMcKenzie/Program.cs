using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viris_Sim_GageMcKenzie
{
    internal class Program
    {
        static List<(int, int)> hi = new List<(int, int)> { (0, 0), (3, 4) };
        static Random movement = new Random();
        
        static void Main(string[] args)
        {
            Console.WriteLine($"-----");
            Console.WriteLine($"---^-");
            Console.WriteLine($"-----");
            Console.WriteLine($"~--^-");
            Console.WriteLine($"~~~~~");


            // char myChar = '8';

            Console.SetCursorPosition(hi[0].Item1, hi[0].Item2);
            Console.ReadKey();
            while (true)
            {
                virismovement();
                Console.ReadKey();
            }
            
            




        }

        static void virismovement()
        {
            int Vmovement = movement.Next(1, 5);
            
            
            
            if (Vmovement == 1)
            {
                hi[0] = (-1, 0);
                int newMovement = hi[0].Item1 -1;
                Console.SetCursorPosition(newMovement, hi[0].Item2);
            }
            if (Vmovement == 2)
            {
                int newMovement = hi[0].Item1 + 1;
                Console.SetCursorPosition(newMovement, hi[0].Item2);
            }
            if (Vmovement == 3)
            {
                int newMovement = hi[0].Item2 - 1;
                Console.SetCursorPosition(hi[0].Item1, newMovement);
            }
            if (Vmovement == 4)
            {
                int newMovement = hi[0].Item2 + 1;
                Console.SetCursorPosition(hi[0].Item1, newMovement);
            }
        }
    }
}
