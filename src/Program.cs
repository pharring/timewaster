using System;
using System.Diagnostics;
using System.Linq;

namespace Timewaster
{
    class Program
    {
        private const int c_buckets = 120;
        private long[] _values = new long[c_buckets];

        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();

            long iterations = 100000000;

            if (args.Length >= 1)
            {
                if (long.TryParse(args[0], out long result))
                {
                    iterations = result;
                }
            }

            Console.WriteLine($"Running {iterations} iterations.");

            var p = new Program();

            Console.WriteLine("Box Muller:");
            p.Run<BoxMullerRandom>(iterations);
            p.Print();

            Console.WriteLine("Abramowitz/Stegun:");
            p.Run<GaussianRandom>(iterations);
            p.Print();

            Console.WriteLine($"Total time: {sw.ElapsedMilliseconds} ms");
        }

        private void Run<T>(long iterations) where T : IGaussianRandom, new()
        {
            _values.Initialize();

            double mean = c_buckets / 2.0;
            double sigma = c_buckets / 6.0;

            var random = new T();

            for (long i = 0; i < iterations; i++)
            {
                long bucketNumber = (long)random.NextGaussian(mean, sigma);
                if (bucketNumber >= 0 && bucketNumber < c_buckets)
                {
                    _values[bucketNumber]++;
                }
            }
        }

        private void Print()
        {
            long max = _values.Max();
            int rows = (int)Math.Min(30, max);
            double scale = (double)max / rows;

            for(int i = 0; i < rows; i++)
            {
                long threshold = (long)(scale * (rows - i));
                foreach(var x in _values)
                {
                    Console.Write(x >= threshold ? '*' : ' ');
                }

                Console.WriteLine();
            }
        }
    }
}
