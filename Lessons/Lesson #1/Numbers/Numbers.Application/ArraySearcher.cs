using System.Collections.Generic;
using Numbers.Application.Exceptions;

namespace Numbers.Application
{
    public class ArraySearcher : IArraySearcher
    {
        private readonly List<int> _numbers;

        public ArraySearcher(List<int> numbers)
        {
            if (numbers == null)
            {
                throw new NullArrayException("Array cannot be null");
            }

            if (numbers.Count == 0)
            {
                throw new EmptyArrayException("Array cannot be empty");
            }

            _numbers = numbers;
        }

        public int GetMinimum()
        {
            var minimal = _numbers[0];

            foreach (var number in _numbers)
            {
                if (minimal > number)
                {
                    minimal = number;
                }
            }

            return minimal;
        }

        public int GetMaximum()
        {
            var maximal = _numbers[0];

            foreach (var number in _numbers)
            {
                if (maximal < number)
                {
                    maximal = number;
                }
            }

            return maximal;
        }
    }
}
