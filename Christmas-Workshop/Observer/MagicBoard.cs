using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Workshop.Observer
{
    public class MagicBoard : ISubject
    {
        private static Lazy<MagicBoard> magicBoard { get; set; } = new Lazy<MagicBoard>();
        private List<IObserver> _observers = new List<IObserver>();
        public string ToyName { get; private set; }

        private MagicBoard()
        {

        }

        public static MagicBoard GetMagicBoard
        {
            get
            {
                if (magicBoard is null)
                {
                    return new MagicBoard();
                }

                return magicBoard.Value;
            }
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
