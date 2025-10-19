using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viris_Sim_GageMcKenzie
{
    internal class Program
    {
        static char[,] Map =
        {
            { '-','-','-','-','-' },
            { '-','-','-','^','-' },
            { '-','-','-','-','-' },
            { '~','-','-','^','-' },
            { '~','~','~','~','~' }
        };
        static List<(int, int)> StartPosition = new List<(int, int)> { (2, 3), (3, 4) };
        static Random movement = new Random();
        
        static void Main(string[] args)
        {
            Console.Write(Map[0,0]);
            Console.Write(Map[0, 1]);
            Console.Write(Map[0, 2]);
            Console.Write(Map[0, 3]);
            Console.WriteLine(Map[0, 4]);
            Console.Write(Map[1, 0]);
            Console.Write(Map[1, 1]);
            Console.Write(Map[1, 2]);
            Console.Write(Map[1, 3]);
            Console.WriteLine(Map[1, 4]);
            Console.Write(Map[2, 0]);
            Console.Write(Map[2, 1]);
            Console.Write(Map[2, 2]);
            Console.Write(Map[2, 3]);
            Console.WriteLine(Map[2, 4]);
            Console.Write(Map[3, 0]);
            Console.Write(Map[3, 1]);
            Console.Write(Map[3, 2]);
            Console.Write(Map[3, 3]);
            Console.WriteLine(Map[3, 4]);
            Console.Write(Map[4, 0]);
            Console.Write(Map[4, 1]);
            Console.Write(Map[4, 2]);
            Console.Write(Map[4, 3]);
            Console.WriteLine(Map[4, 4]);


            // char myChar = '8';

            Console.SetCursorPosition(StartPosition[0].Item1, StartPosition[0].Item2);
            Console.ReadKey();
            while (true)
            {
                virismovement();
                Console.ReadKey();
                Console.Clear();
                Console.Write(Map[0, 0]);
                Console.Write(Map[0, 1]);
                Console.Write(Map[0, 2]);
                Console.Write(Map[0, 3]);
                Console.WriteLine(Map[0, 4]);
                Console.Write(Map[1, 0]);
                Console.Write(Map[1, 1]);
                Console.Write(Map[1, 2]);
                Console.Write(Map[1, 3]);
                Console.WriteLine(Map[1, 4]);
                Console.Write(Map[2, 0]);
                Console.Write(Map[2, 1]);
                Console.Write(Map[2, 2]);
                Console.Write(Map[2, 3]);
                Console.WriteLine(Map[2, 4]);
                Console.Write(Map[3, 0]);
                Console.Write(Map[3, 1]);
                Console.Write(Map[3, 2]);
                Console.Write(Map[3, 3]);
                Console.WriteLine(Map[3, 4]);
                Console.Write(Map[4, 0]);
                Console.Write(Map[4, 1]);
                Console.Write(Map[4, 2]);
                Console.Write(Map[4, 3]);
                Console.WriteLine(Map[4, 4]);
            }
            
            




        }

        static void virismovement()
        {
            int Vmovement = movement.Next(1, 5);
            
            
            
            if (Vmovement == 1)
            {
                if ('-' == Map[StartPosition[0].Item1, StartPosition[0].Item2])
                {
                    Console.SetCursorPosition(StartPosition[0].Item1, StartPosition[0].Item2);
                     Map[StartPosition[0].Item1, StartPosition[0].Item2] = 'X';
                    int XMovement = StartPosition[0].Item1 - 1;
                    (int, int) newPosition = (XMovement, StartPosition[0].Item2);
                    StartPosition[0] = newPosition;
                    Console.SetCursorPosition(XMovement, StartPosition[0].Item2);
                }
                else
                {
                    Console.SetCursorPosition(StartPosition[0].Item1, StartPosition[0].Item2);
                }






            }
            if (Vmovement == 2)
            {
                if ('-' == Map[StartPosition[0].Item1, StartPosition[0].Item2])
                {
                    Console.SetCursorPosition(StartPosition[0].Item1, StartPosition[0].Item2);
                    Console.Write("X");
                    int XMovement = StartPosition[0].Item1 + 1;
                    (int, int) newPosition = (XMovement, StartPosition[0].Item2);
                    StartPosition[0] = newPosition;
                    Console.SetCursorPosition(XMovement, StartPosition[0].Item2);
                }
                else
                {
                    Console.SetCursorPosition(StartPosition[0].Item1, StartPosition[0].Item2);
                }
            }
            if (Vmovement == 3)
            {
                if ('-' == Map[StartPosition[0].Item1, StartPosition[0].Item2])
                {
                    Console.SetCursorPosition(StartPosition[0].Item1, StartPosition[0].Item2);
                    Console.Write("X");
                    int YMovement = StartPosition[0].Item2 - 1;
                    (int, int) newPosition = (StartPosition[0].Item1, YMovement);
                    StartPosition[0] = newPosition;
                    Console.SetCursorPosition(StartPosition[0].Item1, YMovement);
                }
                else
                {
                    Console.SetCursorPosition(StartPosition[0].Item1, StartPosition[0].Item2);
                }
            }
            if (Vmovement == 4)
            {
                if ('-' == Map[StartPosition[0].Item1, StartPosition[0].Item2])
                {
                    Console.SetCursorPosition(StartPosition[0].Item1, StartPosition[0].Item2);
                    Console.Write("X");
                    int YMovement = StartPosition[0].Item2 + 1;
                    (int, int) newPosition = (StartPosition[0].Item1, YMovement);
                    StartPosition[0] = newPosition;
                    Console.SetCursorPosition(StartPosition[0].Item1, YMovement);
                }

                else
                {
                    Console.SetCursorPosition(StartPosition[0].Item1, StartPosition[0].Item2);
                }
            }
        }
    }
}
