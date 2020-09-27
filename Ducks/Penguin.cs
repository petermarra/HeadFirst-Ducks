using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    class Penguin:Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Penguins cant fly!");
        }
        public override string ToString()
        {
            return $"A Penguin named {Name}";
        }
    }
}
