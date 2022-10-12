using System.ComponentModel.Design;

namespace pianino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            Console.SetCursorPosition(55, 1);
            Console.WriteLine("ПИАНИНО");
            Console.SetCursorPosition(25, 2);
            Console.WriteLine("При игре используйте клавиши 'Q','W','E','R','T'-ЧЕРНЫЕ КЛАВИШИ");
            Console.SetCursorPosition(25, 3);
            Console.WriteLine("При игре используйте клавиши 'A','S','D','F','G'-БЕЛЫЕ КЛАВИШИ");
            Octave();
        }

        static void Octave()
        {
            Console.SetCursorPosition(42, 4);
            Console.WriteLine("ВЫБЕРИТЕ ОКТАВУ:ИСПОЛЬЗУЯ F1 И F2");
            do
            {
                WhatOctave();
            } while (true);
        }

        static int[] One()
        {
            int[] FirstOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760 };
            return FirstOctave;
        }
        static int[] Two()
        {
            int[] SecondOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520 };
            return SecondOctave;
        }

        static void WhatOctave()
        {
            ConsoleKeyInfo buttons = Console.ReadKey();
            if (buttons.Key == ConsoleKey.F1)
            {    
             OneOctave();
            }
            if (buttons.Key == ConsoleKey.F2)
            {
                TwoOctave();
            }
        }
        static void OneOctave()
        {
            while (true)
            {
                ConsoleKeyInfo pianino = Console.ReadKey();
                if (pianino.Key == ConsoleKey.A)
                {
                    int[] FirstOctave = One();
                    Console.Beep(FirstOctave[0], 200);
                }
                if (pianino.Key == ConsoleKey.S)
                {
                    int[] FirstOctave = One();
                    Console.Beep(FirstOctave[1], 200);
                }
                if (pianino.Key == ConsoleKey.D)
                {
                    int[] FirstOctave = One();
                    Console.Beep(FirstOctave[2], 200);
                }
                if (pianino.Key == ConsoleKey.F)
                {
                    int[] FirstOctave = One();
                    Console.Beep(FirstOctave[3], 200);
                }
                if (pianino.Key == ConsoleKey.G)
                {
                    int[] FirstOctave = One();
                    Console.Beep(FirstOctave[4], 200);
                }
                if (pianino.Key == ConsoleKey.Q)
                {
                    int[] FirstOctave = One();
                    Console.Beep(FirstOctave[5], 200);
                }
                if (pianino.Key == ConsoleKey.W)
                {
                    int[] FirstOctave = One();
                    Console.Beep(FirstOctave[6], 200);
                }
                if (pianino.Key == ConsoleKey.E)
                {
                    int[] FirstOctave = One();
                    Console.Beep(FirstOctave[7], 200);
                }
                if (pianino.Key == ConsoleKey.R)
                {
                    int[] FirstOctave = One();
                    Console.Beep(FirstOctave[8], 200);
                }
                if (pianino.Key == ConsoleKey.T)
                {
                    int[] FirstOctave = One();
                    Console.Beep(FirstOctave[9], 200);
                }
                if (pianino.Key == ConsoleKey.F2)
                {
                    break;
                }
                if (pianino.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }
        static void TwoOctave()
        {
            while (true)
            {
                ConsoleKeyInfo pianino = Console.ReadKey();
                if (pianino.Key == ConsoleKey.A)
                {
                    int[] SecondOctave = Two();
                    Console.Beep(SecondOctave[0], 200);
                }
                if (pianino.Key == ConsoleKey.S)
                {
                    int[] SecondOctave = Two();
                    Console.Beep(SecondOctave[1], 200);
                }
                if (pianino.Key == ConsoleKey.D)
                {
                    int[] SecondOctave = Two();
                    Console.Beep(SecondOctave[2], 200);
                }
                if (pianino.Key == ConsoleKey.F)
                {
                    int[] SecondOctave = Two();
                    Console.Beep(SecondOctave[3], 200);
                }
                if (pianino.Key == ConsoleKey.G)
                {
                    int[] SecondOctave = Two();
                    Console.Beep(SecondOctave[4], 200);
                }
                if (pianino.Key == ConsoleKey.Q)
                {
                    int[] SecondOctave = Two();
                    Console.Beep(SecondOctave[5], 200);
                }
                if (pianino.Key == ConsoleKey.W)
                {
                    int[] SecondOctave = Two();
                    Console.Beep(SecondOctave[6], 200);
                }
                if (pianino.Key == ConsoleKey.E)
                {
                    int[] SecondOctave = Two();
                    Console.Beep(SecondOctave[7], 200);
                }
                if (pianino.Key == ConsoleKey.R)
                {
                    int[] SecondOctave = Two();
                    Console.Beep(SecondOctave[8], 200);
                }
                if (pianino.Key == ConsoleKey.T)
                {
                    int[] SecondOctave = Two();
                    Console.Beep(SecondOctave[9], 200);
                }
                if (pianino.Key == ConsoleKey.F1)
                {
                    break;
                }
                if (pianino.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
