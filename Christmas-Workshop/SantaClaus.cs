using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Workshop
{
    public class SantaClaus
    {
        private Lazy<SantaClaus> santaClaus { get; set; } = new Lazy<SantaClaus>();

        private SantaClaus()
        {

        }

        public SantaClaus Santa
        {
            get
            {
                if (santaClaus is null)
                {
                    return new SantaClaus();
                }

                return santaClaus.Value;
            }
        }
    }
}
