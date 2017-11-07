using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ConcreteSubject
{
    public class TaylorSwift:ICelebrity
    {
        private readonly List<IFan> _fans = new List<IFan>();
        private string _tweet;

        public TaylorSwift(string t)
        {
            _tweet = t;
        }

        public string FullName => "Taylor Swift";

        public string Tweet
        {
            get => _tweet;
            set
            {
                Notify(value);
            }
        }

        public void AddFollower(IFan fan)
        {
            _fans.Add(fan);
        }

        public void Notify(string tweet)
        {
            _tweet = tweet;
            foreach (var fan in _fans)
            {
                fan.Update(this);
            }
        }

        public void RemoveFollower(IFan fan)
        {
            _fans.Remove(fan);
        }
    }
}
