using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = int.MaxValue;
        }

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int s = queries[i, 0];
            int e = queries[i, 1];
            int k = queries[i, 2];

            for (int j = s; j <= e; j++)
            {
                if (arr[j] > k)
                {
                    if (answer[i] > arr[j])
                        answer[i] = arr[j];
                }
            }

            if (answer[i] == int.MaxValue)
                answer[i] = -1;
        }

        return answer;
    }
}