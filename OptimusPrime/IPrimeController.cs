using System;
using System.Threading;

namespace OptimusPrime
{
    public interface IPrimeController
    {
        long MaxPrimeNumber { get; }

        CancellationTokenSource CancellationTokenSource { set; get;  }

        event EventHandler<PrimeNumberFoundEventArgs> PrimeNumberFound;

        void Generate();
        bool IsPrimeNumber(long input);
        void OnPrimeNumberFound(PrimeNumberFoundEventArgs e);
    }
}