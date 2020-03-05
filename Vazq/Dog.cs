using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Vazq
{
    public class Dog : Animal
    {
        public Dog()
        {

        }
        public Dog(int x, int y = 5) : base(x, y)
        {

        }
        public override void Move()
        {
            int n = rd.Next(101);
            if (n <= 20)
                X += 3;
            else if (n <= 35)
                X += 2;
            else if (n <= 60)
                X -= 2;
            else if (n <= 75)
                X -= 1;
            if (X < 0) X = 0;
            if (X >= WindowWidth) X = WindowWidth - 1;
            int m = rd.Next(101);
            if (m <= 20)
                Y += 3;
            else if (m <= 35)
                Y += 2;
            else if (m <= 60)
                Y -= 2;
            else if (m <= 75)
                Y -= 1;
            if (Y < 0) Y = 0;
            if (Y >= 3) Y = 3 - 1;
        }
    }
}
