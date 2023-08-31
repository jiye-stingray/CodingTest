using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
          public int solution(int[] array, int n)
        {
            int answer = 0;

            Array.Sort(array);

            if(array.Contains(n))
            {
                return n;
            }


            if (array.Length == 1) return array[0];

            int minValue = int.MaxValue;
            int minIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int a = Math.Abs(array[i] - n);
                if(a < minValue)
                {
                    minValue = a;
                    minIndex = i;
                }
                else if(a == minValue)
                {
                    minValue = array[i] < array[minIndex] ? a : minValue;
                    minIndex = array[i] < array[minIndex] ? i : minIndex;
                }

            }

            answer = array[minIndex];
            return answer;
        }
}