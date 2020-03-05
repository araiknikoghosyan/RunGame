using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;

namespace Vazq
{
   public  class Organayzer
    {
        public Animal A1;
        public Animal A2;

        public int Distanc { get; set; } = 70;
        public char Flag { get; set; } = '#';
        public int Interval { get; set; } = 200;
        public Organayzer()
        {
            A1 = null;
            A2 = null;
        }
        public Organayzer(Animal a1, Animal a2)
        {
            A1 = a1;
            A2 = a2; 
        }

        public void Draw(DrawOrclear dr = DrawOrclear.draw)
        {
            A1.Draw(dr);

            A2.Draw(dr);
           
           

        }

        public int Interval1
        {
            set
            {
                if (value >= 10 && value <= 1000)
                {
                    Interval = value;
                }
            }
            get
            {
                return Interval;
            }
        }
        public void Run()
        {
            Console.WriteLine("Enter To intervar in Speed");
             //Clear();
            if (ReadKey().Key == ConsoleKey.S)
            {
                Interval = 10;
            }

            Clear();
            A1.X = A2.X = 0;
            WriteLine("Enter Your Interval Of Game");
            Clear();
            Interval1 = int.Parse(ReadLine());

            SetCursorPosition(Distanc, A1.Y);
            WriteLine(Flag);
            while (true)
            {
                Draw();
                Thread.Sleep(Interval);
                Draw(DrawOrclear.clear);
                A1.Move();
                A2.Move();
                if (A1.X > Distanc)
                {
                    ShowMessage(A1);
                    return; 
                } 
                if (A2.X > Distanc)
                {
                    ShowMessage(A2);
                    return; 
                }
                if (A1.X == A2.X)
                {
                    A1 = new Dog(2) { Name = "Vazgen", Color = ConsoleColor.Red, Icon = (char)444 };
                    A1 = new Pigh(5) { Name = "David", Color = ConsoleColor.Magenta, Icon = (char)94 };
                }
            }  
        }
        public void ShowMessage (Animal a )
        {
            ForegroundColor = a.Color; string text = $"{a.Name} you are winner you are the best";
            SetCursorPosition(WindowWidth / 2 - text.Length / 2, WindowHeight / 2);

            WriteLine(text);
            ResetColor();
            WriteLine("press enter to start new game ");
            if (ReadKey().Key == ConsoleKey.Enter) 
            Run();


        }
    }
}
