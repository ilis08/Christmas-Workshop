using Christmas_Workshop.Toy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Workshop.Command
{
    public interface ICommand
    {
        public IToy GetToy();
    }
}
