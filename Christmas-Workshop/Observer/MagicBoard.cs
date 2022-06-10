using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Workshop.Observer
{
    public class MagicBoard : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public string ToyName { get; private set; }

        private static readonly Lazy<MagicBoard> _magicBoard
              = new(() => new MagicBoard());

        public static MagicBoard Instance
        {
            get
            {
                return _magicBoard.Value;
            }
        }

        protected MagicBoard()
        {

        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void GetChangeToyRequest(string toyName)
        {
            var availableToys = new List<string> { "Bicycle", "Doll" };

            if (availableToys.Contains(toyName))
            {
                ToyName = toyName;
                Notify();
            }
            else
            {
                throw new Exception($"{toyName} toy does not exists");
            }
        }
    }
}
