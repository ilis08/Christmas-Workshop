using Christmas_Workshop.Observer;
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
        public GetBicycleCommand(MagicBoard magicBoard)
        {
            MagicBoard = magicBoard;
        }

        public MagicBoard MagicBoard { get; set; }

        public void GetToy()
        {
            MagicBoard.GetChangeToyRequest("Bicycle");
        }
    }
}
