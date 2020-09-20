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
              new Duck() {Kind=KindOfDuck.Mallard,Size=17},
              new Duck(){Kind=KindOfDuck.Muscovy,Size=18},
              new Duck(){Kind=KindOfDuck.Decoy,Size=14},
              new Duck(){Kind=KindOfDuck.Muscovy,Size=11},
              new Duck(){Kind=KindOfDuck.Mallard,Size=14},
              new Duck() {Kind=KindOfDuck.Decoy,Size=13},

            };
            Console.WriteLine("--Original duck list");
            PrintDucks(ducks);

            //IComparable sort
            Console.WriteLine("\r\n--IComparable Sort -  size descending");
            ducks.Sort();
            PrintDucks(ducks);

            //IComparer sort
            Console.WriteLine("\r\n--IComparer Sort - size ascending");
            DuckCompareBySize sizeComparer = new DuckCompareBySize();
            ducks.Sort(sizeComparer);
            PrintDucks(ducks);

            Console.WriteLine("\r\n--IComparer Sort - Kind ascending by enum index");
            DuckCompareByKind kindComparer = new DuckCompareByKind();
            ducks.Sort(kindComparer);
            PrintDucks(ducks);

            Console.WriteLine("\r\n--IComparer Complex Sort - Size/Kind ascending ");
            DuckComparer comparer = new DuckComparer();
            comparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            Console.WriteLine("\r\n--IComparer Complex Sort - Kind/Size ascending ");
            //DuckComparer comparer = new DuckComparer();
            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);

        }
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (var duck in ducks)
            {
                //Console.WriteLine($"{duck.Size}-inch {duck.Kind.ToString()}");
                //use the override ToString() in the duck class.
                Console.WriteLine(duck);
            }
            Console.WriteLine("End of Ducks");
        }
    }
}
