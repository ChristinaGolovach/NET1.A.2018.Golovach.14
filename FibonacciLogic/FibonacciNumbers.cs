using System;
using System.Numerics;

namespace FibonacciLogic
{
    /// <summary>
    /// Class for the generation of Fibonacci numbers.
    /// </summary>
    public static class FibonacciNumbers
    {
        /// <summary>
        /// Generate the sequence of Fibonacci numbers.
        /// </summary>
        /// <param name="count">
        /// The length of result sequence.
        /// </param>
        /// <returns>
        /// Array of Fibonacci numbers.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the value of <paramref name="count"/> less then one.
        /// </exception>
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

            while (i < count)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
                i++;
            }

            return numbers;
        }
    }
}
