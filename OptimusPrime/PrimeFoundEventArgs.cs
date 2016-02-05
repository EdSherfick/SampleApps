using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusPrime
{
    public class PrimeFoundEventArgs:  EventArgs
    {
        private long _primeNumber;

        public long PrimeNumber
        {
            get
            {
                return _primeNumber;
            }

            set
            {
                _primeNumber = value;
            }
        }
    }
}
