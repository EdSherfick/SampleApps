using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusPrime
{
    public class SimplePrimeController
    {
        public event EventHandler PrimeFound;

        private long _lastPrimeNumberFound = -1;

        public long LastPrimeNumber
        {
            get
            {
                return _lastPrimeNumberFound;
            }

            private set
            {
                _lastPrimeNumberFound = value;
            }
        }

        public void Generate()
        {
            //TODO:  Create range of numbers
            //TODO:  Iterate through numbers and test for prime.  
            //TODO:  Raise PrimeFoundEvent
        }

        public bool IsPrime(int input)
        {
            var result = false;

            //TODO:  logic to test for prime

            return result;
        }

        protected virtual void OnPrimeFound(PrimeFoundEventArgs e)
        {
            if (PrimeFound != null)
                PrimeFound(this, e);
        }

        private void RaisePrimeFound(long value)
        {
            //TODO:  Set MaxPrimeFound
            OnPrimeFound(new PrimeFoundEventArgs() { PrimeNumber = value } );
        }
    }
}
