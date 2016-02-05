using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OptimusPrime
{
    public class SimplePrimeController : ISimplePrimeController
    {
        public event EventHandler<PrimeNumberFoundEventArgs> PrimeNumberFound;

        private long _maxPrimeNumberFound = -1;

        CancellationTokenSource _cts = new CancellationTokenSource();
        public long MaxPrimeNumber
        {
            get
            {
                return _maxPrimeNumberFound;
            }

            private set
            {
                _maxPrimeNumberFound = value;
            }
        }

        public CancellationTokenSource Cts
        {
            get
            {
                return _cts;
            }

            set
            {
                _cts = value;
            }
        }

        public void Generate()
        {
            var maxTestNumber = long.MaxValue;
            var status = string.Empty;

            // loop for a long as you can
            for (long i = 1; i <= maxTestNumber; i++)
            {
                // this sleep line is required to repaint the form window properly.  
                // without it the countdown timer will have a delayed start
                Thread.Sleep(0);

                // if this is asynchronous, then we need to see if the task was cancelled
                if ((_cts != null) && (_cts.Token.IsCancellationRequested))
                {
                    // thread was canceled, so quit processing
                    return;
                }

                //test if the number is prime
                if (IsPrimeNumber(i))
                {                  
                    // write all prime numbers to the output window
                    //Debug.WriteLine(string.Format(CultureInfo.InvariantCulture, "{0:#,0}", i));

                    // prime so raise an event to pass the prime number to the consumer
                    RaisePrimeNumberFound(i);
                }
            }
        }

        public bool IsPrimeNumber(long input)
        {
            // 1 is generally not considered a prime
            if (input == 1)
            {
                return false;
            }

            // 2 and 3 are known primes
            if ((input == 2) || (input == 3))
            {
                return true;
            }

            // Test all divisors up to the square root of the input.
            // Don't use square root function because it's more slower than a multiplication test.
            for (long divisor = 2; divisor * divisor <= input; divisor++)
            {
                //skip divisors that are even or divisible by 5.
                if ((divisor % 2 == 0) && (divisor % 5 == 0))
                {
                    continue;
                }

                // test for remainder of 0
                if (input % divisor == 0)
                {
                    // Composite Number:  testNumber is divisible. 
                    return false;
                }
            }

            // input is not divisible  
            return true;
        }

        public virtual void OnPrimeNumberFound(PrimeNumberFoundEventArgs e)
        {
            if (PrimeNumberFound != null)
                PrimeNumberFound(this, e);
        }

        private void RaisePrimeNumberFound(long primeNumber)
        {
     
            //set the max prime number found
            MaxPrimeNumber = primeNumber;

            //pass the prime to the consumer
            OnPrimeNumberFound(new PrimeNumberFoundEventArgs() { PrimeNumber = primeNumber } );
        }
    }
}
