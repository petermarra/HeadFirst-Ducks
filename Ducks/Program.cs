using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
              new Duck() {Kind=KindOfDuck.Mallard,size=17},
              new Duck(){Kind=KindOfDuck.Muscovy,size=18},
              new Duck(){Kind=KindOfDuck.Decoy,size=14},
              new Duck(){Kind=KindOfDuck.Muscovy,size=11},
              new Duck(){Kind=KindOfDuck.Mallard,size=14},
              new Duck() {Kind=KindOfDuck.Decoy,size=13},

            };

            Console.ReadKey();
        }
    }
}
