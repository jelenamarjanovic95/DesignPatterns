using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Iterator;

namespace IteratorPattern.Aggregate
{
    public class LAPaper : INewspaper
    {
        private string[] _reporters;
        public LAPaper()
        {
            //collection - array
            _reporters = new[]
            {
                "Jelena - LA",
                "Jelena - LA",
                "Jelena - LA",
                "Jelena - LA",
                "Jelena - LA",
                "Jelena - LA",
                "Jelena - LA",
                "Jelena - LA"
            };
        }

        public IIterator CreateIterator() => new LaPaperIterator(_reporters);
       
    }
}
