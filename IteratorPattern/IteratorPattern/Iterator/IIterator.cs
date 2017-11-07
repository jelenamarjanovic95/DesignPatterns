using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    public interface IIterator
    {
        void First();
        string Next();
        bool isDone();
        string CurrentItem();
    }
}
