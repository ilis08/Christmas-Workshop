using Christmas_Workshop.Factory;
using Christmas_Workshop.Observer;
using Christmas_Workshop.Toy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Workshop.Models
{
    public class Dwarf : IObserver
    {
        private readonly string name;
        private ToyFactory factory;
        private ISubject subject;

        public Dwarf(string _name)
        {
            name = _name;   
        }

        public void Update(ISubject subject)
        {
            if (subject is null)
            {
                Console.WriteLine($"Dwarf {name} is not currently following the magic board");
            }

            factory = GetToyFactory(subject.ToyName);

            var toy = factory.CreateToy();

            if (toy is not null)
            {
                Console.WriteLine($"Dwarf brought {toy.Name} toy from factory");
            }
        }

        public static ToyFactory GetToyFactory(string toyName)
        {
            return toyName switch
            {
                "Bicycle" => new BicycleFactory(),
                "Doll" => new DollFactory(),
                _ => throw new ArgumentException(),
            };
        }

        public void SetSubject(ISubject _subject)
        {
            subject = _subject;
        }
    }
}
