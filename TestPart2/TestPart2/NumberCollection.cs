using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPart2
{
    class NumberCollection
    {
        List<int> _numbers = new List<int>();
        private int? _highestNumber = null;
        private int? _lowestNumber = null;


        public void Push(int number)
        {
            _numbers.Insert(0, number);
            _highestNumber = _numbers.Max();
            _lowestNumber = _numbers.Min();
        }

        public int? Pop()
        {
            if (_numbers.Count > 0)
            {
                int result = _numbers[0];
                _numbers.RemoveAt(0);

                if (_numbers.Count > 0)
                {
                    _highestNumber = _numbers.Max(); //seems too easy hmmmmmmm.....
                    _lowestNumber = _numbers.Min();
                }
                else
                {
                    _highestNumber = null;
                    _lowestNumber = null;
                }

                return result;
            }
            else
                return null;
        }

        public int? Peep()
        {
            if (_numbers.Count > 0)
                return _numbers[0];
            else
                return null;
        }

        public void PrintAll()
        {
            Console.WriteLine("--------list--------");
            for (int i = _numbers.Count; i > 0; i--)
            {
                Console.Write(_numbers[i - 1] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Highest: {_highestNumber}");
            Console.WriteLine($"Lowest: {_lowestNumber}");
            Console.WriteLine("--------------------");
        }
    }
}
