using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Search
{
    public class BinarySearch
    {
        public int Search(int element, int[] elementArray, int first, int last)
        {
            int mid = (first + last) / 2;

            if (element == elementArray[mid])
            {
                return mid;
            }
            else if(element < elementArray[mid])
            {
                return Search(element, elementArray, 0, mid - 1);
            }
            else
            {
                return Search(element, elementArray, mid+1, last);
            }
        }
    }
}
