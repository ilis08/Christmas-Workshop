using Christmas_Workshop.Toy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Workshop.Factory
{
    public abstract class ToyFactory
    {
        public abstract IToy CreateToy();
    }
}
