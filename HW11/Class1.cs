using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    public static class ArrayExtensions
    {
        public static int[] Filter(this int[] array, Predicate<int> predicate)
        {
            int count = 0;
            foreach (int item in array)
            {
                if (predicate(item))
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;
            foreach (int item in array)
            {
                if (predicate(item))
                {
                    result[index++] = item;
                }
            }

            return result;
        }
    }

}
