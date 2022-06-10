using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Workshop
{
    public class MagicBoard
    {
        private Lazy<MagicBoard> magicBoard { get; set; } = new Lazy<MagicBoard>();

        private MagicBoard()
        {

        }

        public MagicBoard GetMagicBoard
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
    }
}
