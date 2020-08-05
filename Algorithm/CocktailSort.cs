using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// Cocktail shaker sorting algorithm
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CocktailSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while (left < right)
            {
                var tempSwopCount = SwopCount;

                for (int i = left; i < right; i++)
                {
                    if (Compare(Items[i], Items[i + 1]) == 1)
                    {
                        Swop(i, i + 1);
                        ComparsionCount++;
                    }
                }

                right--;

                if (tempSwopCount == SwopCount)
                {
                    break;
                }

                for (int i = right; i > left; i--)
                {
                    if (Compare(Items[i], Items[i - 1]) == -1)
                    {
                        Swop(i - 1, i);
                        ComparsionCount++;
                    }
                }

                left++;
            }
        }
    }
}
