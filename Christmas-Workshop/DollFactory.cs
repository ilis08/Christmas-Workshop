using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Workshop
{
    public class DollFactory : ToyFactory
    {
        public override IToy CreateToy()
        {
            return new Doll();  
        }
    }
}
