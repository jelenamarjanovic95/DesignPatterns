using IteratorPattern.Aggregate;
using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Program
    {
        static void Main(string [] args)
        {
            INewspaper ny = new NYPaper();
            INewspaper la = new LAPaper();

            IIterator nyi = ny.CreateIterator();
            IIterator lai = la.CreateIterator();

            Console.WriteLine("------------    NY paper");
            PrintReporters(nyi);
            Console.WriteLine("------------    LA paper");
            PrintReporters(lai);
        }

        private static void PrintReporters(IIterator i)
        {
            i.First();
            while (!i.isDone())
            {
                Console.WriteLine(i.Next());
            }
        }
    }
}
