using System;
using System.Numerics;

namespace FibonacciLogic
{
    public static class FibonacciNumbers
    {

        public static BigInteger[] GenerateSequence(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException($"The {nameof(count)} must be more than one.");
            }

            if (count == 1)
            {
                return new BigInteger[] { 1 };
            }

            BigInteger[] numbers = new BigInteger[count];

            numbers[0] = 1;
            numbers[1] = 1;
            int i = 2;

            while(i < count)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
                i++;
            }

            return numbers;
        }
    }
}
