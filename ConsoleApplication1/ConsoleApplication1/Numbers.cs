using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class Numbers
    {
        public static int SumOfTwoHighestNumbers(List<int> numbers)
        {
            if (numbers == null)
                return 0;

            int num1 = 0;
            int num2 = 0;
            int highestIndex = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > num1)
                {
                    num1 = numbers[i];
                    highestIndex = i;
                }
            }

            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[j] > num2 && j != highestIndex)
                    num2 = numbers[j];
            }

            return num1 + num2;
        }
    }
}
