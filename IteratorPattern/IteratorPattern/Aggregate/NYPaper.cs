using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Iterator;

namespace IteratorPattern.Aggregate
{
    public class NYPaper:INewspaper
    {
        private List<string> _reporters;
        public NYPaper()
        {
            //collection - array
            _reporters = new List<string>
            {
                "Jelena - NY",
                "Jelena - NY",
                "Jelena - NY",
                "Jelena - NY",
                "Jelena - NY",
                "Jelena - NY",
                "Jelena - NY",
                "Jelena - NY"
            };
        }

        public IIterator CreateIterator() => new NYPaperIterator(_reporters);
        
    }
}

