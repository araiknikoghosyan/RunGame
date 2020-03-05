using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;

namespace Vazq
{
     public  class  Pigh:Animal
    {
       
        public Pigh(int x , int y =5)
        {
            X = x;
            Y = y;

        }
        public Pigh()
        {

        }
        public override void Move()
        {

            
            int m = rd.Next(101);
            if (m <= 20)
                X += 5;
            else if (m <= 30)
                X += 3;
            else if (m <= 55)
                X -= 3;
            else if (m <= 60)
                X -= 2;
            if (X < 0) X = 0;
            if (X >= WindowWidth) X = WindowWidth - 1;
            int n = rd.Next(101);
            if (n <= 20)
                Y += 5;
            else if (n <= 30)
                Y += 3;
            else if (n <= 55)
                Y -= 3;
            else if (n <= 60)
                Y -= 2;
            if (Y < 0) Y = 0;
            if (Y >=3) Y=3- 1;
            
        }
       
    }
}
