using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Subject;

namespace ObserverPattern.ConcreteObserver
{
    public class Jelena : IFan
    {
        public void Update(ICelebrity celeb)
        {
            Console.WriteLine($"Fan notified. Tweet of {celeb.FullName}: {celeb.Tweet}");
        }
    }
}
