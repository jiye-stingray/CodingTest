using System;

public class Solution {
    public int[,] solution(int[,] arr) {
        int[,] answer = new int[,] { { } };

        int i = arr.GetLength(0);
        int j = arr.GetLength(1);

        int max = Math.Max(i,j);

        answer = new int[max, max];

        for (int n = 0; n < max; n++)
        {
            for (int m = 0; m < max; m++)
            {
                if (n < i && m < j)
                {
                    answer[n, m] = arr[n, m];
                }
                else
                    answer[n, m] = 0;
            }
        }

        return answer;
    }
}