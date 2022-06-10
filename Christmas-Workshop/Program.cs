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
            var santa = SantaClaus.GetSanta;

            santa.Toys.Add(new Doll());


        }
    }
}
