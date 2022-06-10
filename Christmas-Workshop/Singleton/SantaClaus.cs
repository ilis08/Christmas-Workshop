using Christmas_Workshop.Command;
using Christmas_Workshop.Observer;
using Christmas_Workshop.Toy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Workshop.Singleton
{
    public class SantaClaus
    {
        public List<IToy> Toys { get; set; } = new List<IToy>();
        private ICommand command;

        private static readonly Lazy<SantaClaus> _santaClaus
              = new(() => new SantaClaus());

        public static SantaClaus Instance
        {
            get
            {
                return _santaClaus.Value;
            }
        }

        protected SantaClaus()
        {

        }

        public void GiveMeAToys(MagicBoard magicBoard)
        {
            foreach (var toy in Toys)
            {
                if (toy is Bicycle)
                {
                    Console.WriteLine("Santa wants a bicycle toy.");
                    command = new GetBicycleCommand(magicBoard);
                    command.GetToy();
                }
                else if(toy is Doll)
                {
                    Console.WriteLine("Santa wants a doll toy.");
                    command = new GetDollCommand(magicBoard);
                    command.GetToy();
                }
            }
        }
    }
}
