using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusPrime
{
    public class PrimeNumberFoundEventArgs:  EventArgs
    {
        public long PrimeNumber { get; set;  }
    }
}
