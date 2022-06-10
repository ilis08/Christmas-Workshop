using Christmas_Workshop.Toy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Workshop.Command
{
    public class GetBicycleCommand : ICommand
    {
        private readonly MagicBoard magicBoard;

        public GetBicycleCommand(MagicBoard magicBoard)
        {
            this.magicBoard = magicBoard;
        }

        public IToy GetToy()
        {
            throw new NotImplementedException();
        }
    }
}
