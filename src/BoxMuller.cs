using System;

namespace Timewaster
{
    internal class BoxMullerRandom : IGaussianRandom
    {
        private readonly Random _rnd = new Random();
        private const double Tau = Math.PI * 2;

        /// <summary>
        /// Choose the next random number. The distribution of randomness is "normal"
        /// or "Gaussian" with a mean value dMu and a standard deviation of dSigma
        /// </summary>
        /// <param name="dMu">The center point (mean) of the normal distribution</param>
        /// <param name="dSigma">The standard deviation of the distribution</param>
        /// <returns>Random value</returns>
        public double NextGaussian(double dMu, double dSigma) =>
            dMu + CumulativeGaussian() * dSigma;

        private double CumulativeGaussian()
        {
            double u1 = 1.0 - _rnd.NextDouble();
            double u2 = 1.0 - _rnd.NextDouble();
            return Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(Tau * u2);
        }
    }
}
