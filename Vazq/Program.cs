using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;

namespace Vazq
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog(2) { Name = "Jeyme", Color = ConsoleColor.Blue, Icon = (char)123 };

            Pigh pigh = new Pigh(4) { Name = "irina ", Color = ConsoleColor.Yellow, Icon = (char)333 };

            Organayzer org = new Organayzer(dog, pigh);
            org.Run();



        }
    }
}
