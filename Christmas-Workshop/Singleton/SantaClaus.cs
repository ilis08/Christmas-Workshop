using Christmas_Workshop.Command;
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
        private static Lazy<SantaClaus> santaClaus { get; set; } = new Lazy<SantaClaus>();
        public List<IToy> Toys { get; set; }
        private ICommand command;

        private SantaClaus()
        {

        }

        public static SantaClaus GetSanta
        {
            get
            {
                if (santaClaus is null)
                {
                    return new SantaClaus();
                }

                return santaClaus.Value;
            }
        }

        public void GiveMeAToys()
        {
            
        }
    }
}
