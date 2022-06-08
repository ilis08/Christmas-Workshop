using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Workshop
{
    public interface IToy
    {
        public string Name { get; }

        public void A();

        public void B()
        {
            Console.WriteLine("B");
        }
    }
}
