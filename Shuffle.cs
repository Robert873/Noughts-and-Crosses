using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrosses
{
    class Shuffle
    {
        public Shuffle(int size)
        {
            for (int i = 1; i <= size; i++)
                numbers.Add(i);
        }

        public int GetNumber()
        {
            int index = rng.Next(numbers.Count);
            return numbers[index];
        }

        public void RemoveNumber(int value) 
        {
            numbers.Remove(value);
        }

        Random rng = new Random();
        private List<int> numbers = new List<int>();
    }
}
