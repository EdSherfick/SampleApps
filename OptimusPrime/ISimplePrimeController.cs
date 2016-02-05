using System;

namespace OptimusPrime
{
    public interface ISimplePrimeController
    {
        long MaxPrimeNumber { get; }

        event EventHandler<PrimeNumberFoundEventArgs> PrimeNumberFound;

        void Generate();
        bool IsPrimeNumber(long input);
        void OnPrimeNumberFound(PrimeNumberFoundEventArgs e);
    }
}