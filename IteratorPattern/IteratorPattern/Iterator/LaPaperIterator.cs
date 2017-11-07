using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
   
    public class LaPaperIterator : IIterator
    {
        private string[] _reporters;
        private int _current;

        public LaPaperIterator(string [] reps)
        {
            _reporters = reps;
            _current = 0;
        }

        public string CurrentItem() => _reporters[_current];
        

        public void First()
        {
            _current = 0;
        }

        public bool isDone() => _current >= _reporters.Length;

        public string Next() => _reporters[_current++];
    }
}
