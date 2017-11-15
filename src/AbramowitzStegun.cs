using System;

namespace Timewaster
{
    internal class AbramowitzStegun : IGaussianRandom
    {
        private readonly Random _rnd = new Random();

        /// <summary>
        /// Choose the next random number. The distribution of randomness is "normal"
        /// or "Gaussian" with a mean value dMu and a standard deviation of dSigma
        /// </summary>
        /// <param name="dMu">The center point (mean) of the normal distribution</param>
        /// <param name="dSigma">The standard deviation of the distribution</param>
        /// <returns>Random value</returns>
        public double NextGaussian(double dMu, double dSigma) =>
            dMu + CumulativeGaussian(_rnd.NextDouble()) * dSigma;

        /// <summary>
        /// Apply the inverse cumulative Gaussian distribution function.
        /// i.e. convert a rectangular probability into a Gaussian distribution.
        /// </summary>
        /// <param name="p">
        /// A value between 0 and 1 representing a probability from a rectangular
        /// distribution.
        /// </param>
        /// <returns>
        /// A value x where Q(x)=psuch that <code>Prob(Z &lt; x) = p</code> where Z is the
        /// standard normal (Gaussian) distribution.
        /// </returns>
        /// <remarks>
        /// Because of the symmetry of the normal distribution, we need
        /// only consider 0 &lt; p &lt;= 0.5. For p &gt; 0.5, apply the algorithm
        /// to 1-p and negate the result.
        /// </remarks>
        private static double CumulativeGaussian(double p) => 
            p <= 0.5 ? Approximation(p) : -Approximation(1 - p);

        /// <summary>
        /// This is an approximation by Abramowitz and Stegun.
        /// See 26.2.23 at http://people.math.sfu.ca/~cbm/aands/page_933.htm
        /// </summary>
        /// <param name="p">
        /// Input probability (rectangular). Must be between 0 and 0.5.
        /// </param>
        /// <returns>
        /// A rational approximation for x where Q(x)=p and Q is the
        /// complementary cumulative distribution function for a standard
        /// normal distribution.
        /// </returns>
        private static double Approximation(double p)
        {
            //double t = Math.Sqrt(Math.Log(1.0 / (p * p)));
            double t = Math.Sqrt(-2.0 * Math.Log(p));
            double tt = t * t;
            double ttt = tt * t;
            return t - ((c0 + c1 * t + c2 * tt) / (1 + d1 * t + d2 * tt + d3 * ttt));
        }

        private const double c0 = 2.515517;
        private const double c1 = 0.802853;
        private const double c2 = 0.010328;
        private const double d1 = 1.432788;
        private const double d2 = 0.189269;
        private const double d3 = 0.001308;
    }
}
