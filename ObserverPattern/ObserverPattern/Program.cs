using ObserverPattern.ConcreteObserver;
using ObserverPattern.ConcreteSubject;
using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICelebrity ts = new TaylorSwift("Hello world");
            ICelebrity er = new TaylorSwift("Hello world");

            IFan fan1 = new Jelena();

            ts.AddFollower(fan1);
            ts.Tweet = "New tweet everyone!";
            ts.Tweet = "Another one";
        }
    }
}
