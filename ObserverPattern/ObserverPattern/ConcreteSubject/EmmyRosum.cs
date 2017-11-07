using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observer;

namespace ObserverPattern.ConcreteSubject
{
    public class EmmyRosum : ICelebrity
    {
        private readonly List<IFan> _fans = new List<IFan>();
        private string _tweet;

        public EmmyRosum(string t)
        {
            _tweet = t;
        }

        public string FullName => "Emmy Rossum";

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
            foreach(var fan in _fans)
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
