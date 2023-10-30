using System;

public class Solution {
    public int solution(int[] citations) {
        int answer = 0;

        int num = 0;

        for (int i = 0; i < 10000; i++)
        {
            num = 0;

            for (int j = 0; j < citations.Length; j++)
            {
                if (citations[j] - i >= 0)
                    num++;
            }

            if(num >= i && i > answer)
                answer = i;

        }
        
        return answer;
    }
}