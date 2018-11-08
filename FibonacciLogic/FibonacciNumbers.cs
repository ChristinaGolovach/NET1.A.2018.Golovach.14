using System;

namespace FibonacciLogic
{
    public static class FibonacciNumbers
    {

        public static ulong[] GenerateSequence(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException($"The {nameof(count)} must be more than one.");
            }

            if (count == 1)
            {
                return new ulong[] { 1 };
            }

            ulong[] numbers = new ulong[count];

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
