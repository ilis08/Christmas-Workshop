using Christmas_Workshop.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Workshop.Command
{
    public class GetDollCommand : ICommand
    {
        public GetDollCommand(MagicBoard magicBoard)
        {
            MagicBoard = magicBoard;
        }

        public MagicBoard MagicBoard { get ; set; }

        public void GetToy()
        {
            MagicBoard.GetChangeToyRequest("Doll");
        }
    }
}
