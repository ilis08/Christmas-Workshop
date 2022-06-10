using Christmas_Workshop.Models;
using Christmas_Workshop.Observer;
using Christmas_Workshop.Singleton;
using Christmas_Workshop.Toy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Workshop
{
    public class Program
    {
        public static void Main()
        {
            var santa = SantaClaus.Instance;

            santa.Toys.Add(new Doll());
            santa.Toys.Add(new Bicycle());

            MagicBoard magicBoard = MagicBoard.Instance;

            var dwarf1 = new Dwarf("Alex");
            var dwarf2 = new Dwarf("Ivan");

            dwarf1.SetSubject(magicBoard);
            dwarf2.SetSubject(magicBoard);

            magicBoard.Attach(dwarf1);
            magicBoard.Attach(dwarf2);

            santa.GiveMeAToys(magicBoard);
        }
    }
}
