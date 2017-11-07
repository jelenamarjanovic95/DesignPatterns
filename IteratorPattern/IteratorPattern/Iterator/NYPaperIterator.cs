using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    public class NYPaperIterator : IIterator
    {
        private List<string> _reporters;
        private int _current;

        public NYPaperIterator(List<string> reps)
        {
            _reporters = reps;
            _current = 0;
        }

        public string CurrentItem() => _reporters.ElementAt(_current);
        
        public void First()
        {
            _current = 0;
        }

        public bool isDone() => _current >= _reporters.Count;

        public string Next() => _reporters.ElementAt(_current++);
    }
}
