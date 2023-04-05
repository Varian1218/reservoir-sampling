using System;

namespace ReservoirSamplings
{
    public class ReservoirSampling
    {
        private Random _random;

        public int Seed
        {
            set => _random = new Random(value);
        }

        public bool Next(int index)
        {
            return _random.Next(index + 1) < 1;
        }

        public bool Next(int index, int length, out int value)
        {
            value = _random.Next(index + 1);
            return value < length;
        }

        public int NextInt(int index)
        {
            return _random.Next(index + 1);
        }
    }
}