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

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > num1)
                {
                    num2 = num1;
                    num1 = numbers[i];
                }
                else if (numbers[i] > num2)
                {
                    num2 = numbers[i];
                }
            }

            return num1 + num2;
        }
    }
}
