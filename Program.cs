using System.Collections.Generic;

namespace ListOfDucks
{
    internal class Program
    {
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine($"{duck.Size} inch {duck.Kind}");
            }
        }
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck(){Kind=KindOfDuck.Mallard,Size=17},
                new Duck(){ Kind=KindOfDuck.Muscovy,Size=18},
                new Duck(){ Kind=KindOfDuck.Loon,Size=14},
                new Duck(){ Kind=KindOfDuck.Muscovy,Size=11},
                new Duck(){ Kind=KindOfDuck.Mallard,Size=14},
                new Duck(){Kind=KindOfDuck.Loon,Size=13},
            };

            IComparer<Duck> sizeComparer = new DuckComparerBySize();
            IComparer<Duck> kindComparer = new DuckComparerByKind();

            DuckComparer comparer = new DuckComparer();
            Console.WriteLine($"Sorting by Kind then Size");
            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);
            Console.WriteLine($"\n\nSorting by Size then Kind");
            comparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);


            //ducks.Sort(kindComparer);
            //ducks.Sort(sizeComparer);
            //ducks.Sort();
            PrintDucks(ducks);
        }
    }
}