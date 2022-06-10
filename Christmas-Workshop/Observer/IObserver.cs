using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Workshop.Observer
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
