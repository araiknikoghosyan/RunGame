using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Vazq
{

    public enum DrawOrclear { draw , clear} 
     public abstract class Animal
    {

      protected  static Random rd = new Random();
        public string Name { get; set; } = "Unname";
        public int X { get; set; } = 0;
        public int Y { get; set; } = 5;
        public char Icon { get; set; } = (char)1;
        public ConsoleColor Color { get; set; } = ConsoleColor.Red;

        public Animal(int x , int y = 5 )
        {
            X = x;
            Y = y;
        }
        public Animal()
        {

        }
        public override string ToString()
        {
            return $"{Name}\t{X}\t{Y}\t{Color}";

        }


        public void  Draw(DrawOrclear dr = DrawOrclear.draw)
        {
            ForegroundColor = dr ==DrawOrclear.draw ? Color : BackgroundColor;

            SetCursorPosition(X, Y);
            Console.WriteLine(Icon);
            ResetColor();
        }
        public abstract void Move();
       
    }
}
